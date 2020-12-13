using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBA
{
    class Program
    {
        static void Main(string[] args)
        {
            CentraleFactory centraleFactory = new CentraleFactory();

            //CentralGaz central1 = centraleFactory.Get(ObjectType.CentralGaz, 100, 50,120) as CentralGaz;
            //CentralNucl central2 = centraleFactory.Get(ObjectType.CentralNucl, data) as CentralNucl;
            CentralEolien central3 = centraleFactory.Get(ObjectType.CentralEolien, 100,50,120) as CentralEolien;
            //CentralSolaire central4 = centraleFactory.Get(ObjectType.CentralSolaire, data) as CentralSolaire;
            //CentralAcheteur central5 = centraleFactory.Get(ObjectType.CentralAcheteur, data) as CentralAcheteur;
            
            Console.WriteLine(central3.GetInfo());
            //central3.MeteoFavorable();
            //Console.WriteLine(central3.GetInfo());
            //Console.WriteLine(central2.GetInfo());

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            
            weatherData.AddSubscriber(central3);        
            
            weatherData.SetMeasurements(30); 
            weatherData.SetMeasurements(5);
            weatherData.SetMeasurements(-200);
    

            Console.WriteLine(central3.GetInfo());

            



        }
    }

    public interface IWeatherPublisher
    {
        void AddSubscriber(IWeatherObserver subscriber);
        void RemoveSubscriber(IWeatherObserver subscriber);
        void NotifyObservers();
    }

    public interface IWeatherObserver
    {  
        void Update(float temp);
    }

    public interface IDisplayElement
    {
        void Display();
    }

    public class WeatherData : IWeatherPublisher
    {
        private IList<IWeatherObserver> observers = new List<IWeatherObserver>();
        private float temperature;

        public WeatherData()
        {
            observers = new List<IWeatherObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }

        public void AddSubscriber(IWeatherObserver subscriber)
        {
            observers.Add(subscriber);
        }

        public void RemoveSubscriber(IWeatherObserver subscriber)
        {
            if (observers != null && observers.Count() > 0)
            {
                observers.Remove(subscriber);
            }
        }

        public void SetMeasurements(float temperature)
        {
            this.temperature = temperature;

            NotifyObservers();
        }
        // peut etre un getter?
    }

    public class CurrentConditionsDisplay : IWeatherObserver, IDisplayElement
    {
        private float temperature;
        private IWeatherPublisher _weatherData;

        public CurrentConditionsDisplay(IWeatherPublisher weatherData)
        {
            _weatherData = weatherData;

            weatherData.AddSubscriber(this);
        }

        public void Update(float temperature)
        {
            this.temperature = temperature;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + " degrees celcius");
        }
    }

    interface ICentral
    {
        String GetInfo();
    }

    interface IProductionFlexible
    {
        int ProdUp();
        int ProdDown();
    }

    class CentralGaz : ICentral, IProductionFlexible
    {
        private int production;
        private int coutProd;
        private int co2prod;

        public CentralGaz(int a, int b, int c)
        {
            this.production = a;
            this.coutProd = b;
            this.co2prod = c;
        }

        public int ProdUp()
        {
            return (this.production += 10);
        }

        public int ProdDown()
        {
            return (this.production -= 10);
        }

        public virtual String GetInfo()
        {
            return String.Format("Je produis {0} W par seconde, je coute {1} euro par W produit et je polue {2} co2 par secondes", production, coutProd,co2prod);
        }
    }

    interface IDepandantMeteo
    {
        int MeteoFavorable();
        int MeteoDefavorable();
        int MeteoNoEff();
    
    }

    class CentralEolien : ICentral, IDepandantMeteo, IWeatherObserver
    {
        private int production;
        private int coutProd;
        private int co2prod;
        private float temperature;

        public void Update(float temperature)
        {
            this.temperature = temperature;

            if (temperature <= 50 & temperature >= 5)
            {
                MeteoFavorable();
            }
            else if (temperature < 90 & temperature > 50)
            {
                MeteoNoEff();
            }
                
            else {
                MeteoDefavorable();  
            }
        }

        public CentralEolien(int a, int b, int c)
        {
            this.production = a;
            this.coutProd = b;
            this.co2prod = c;
        }

        public int MeteoFavorable()
        {
            return production += 10;
        }
        public int MeteoDefavorable()
        {
            return production -= 10;
        }
        public int MeteoNoEff()
        {
            return production += 0;
        }


        public virtual String GetInfo()
        {
            return String.Format("Je produis {0} W par seconde, je coute {1} euro par W produit et je polue {2} co2 par secondes", production, coutProd, co2prod);
        }
    }

    class CentralSolaire : ICentral
    {

        public virtual String GetInfo()
        {
            return String.Format("bientot je serais interessant");
        }
    }
    class CentralAcheteur : ICentral
    {

        public virtual String GetInfo()
        {
            return String.Format("bientot je serais interessant");
        }
    }

    class CentralNucl : ICentral
    {

        public virtual String GetInfo()
        {
            return String.Format("Bientot moi aussi je serai interessant");
        }
    }

    enum ObjectType
    {
        CentralNucl,
        CentralGaz,
        CentralEolien,
        CentralSolaire,
        CentralAcheteur
    }


    class CentraleFactory
    {
        ObjectType _type;
        int production;
        int coutProd;
        int co2prod;

        public ICentral Get(ObjectType type, int a, int b, int c)
        {
            _type = type;
            production = a;
            coutProd = b;
            co2prod = c;

            return GetObject();
        }

        public ICentral GetObject()
        {
            ICentral obj = null;

            switch (_type)
            {
                case ObjectType.CentralGaz:
                    obj = new CentralGaz(production, coutProd, co2prod) { };
                    break;
                case ObjectType.CentralNucl:
                    obj = new CentralNucl() { };
                    break;
                case ObjectType.CentralEolien:
                    obj = new CentralEolien(production, coutProd, co2prod) { };
                    break;
                case ObjectType.CentralSolaire:
                    obj = new CentralSolaire() { };
                    break;
                case ObjectType.CentralAcheteur:
                    obj = new CentralAcheteur() { };
                    break;
            }

            return obj;
        }
    }


}