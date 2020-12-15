using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjtInfoBA3_2
{
    [Serializable]
    public abstract class CentreControle
    {

        //WeatherData weatherData = new WeatherData();


        public CentreControle()
        {
            //CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            //weatherData.SetMeasurements(30);
            //weatherData.SetMeasurements(5);
            //weatherData.SetMeasurements(-200);

        }

        //var central3 = CentralFactory.Build("eolien", 100, 50, 20);

        //Console.WriteLine(central3.GetInfo());


        //WeatherData weatherData = new WeatherData();

        //CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

        //weatherData.AddSubscriber((CentralEolien) central3); 

        //weatherData.SetMeasurements(30); 
        //weatherData.SetMeasurements(5);
        //weatherData.SetMeasurements(-200);


        //Console.WriteLine(central3.GetInfo());

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

    public interface ICentral
    {
        int getProd();
        String GetInfo();
    }

    interface IProductionFlexible
    {
        int ProdUp();
        int ProdDown();
    }

    [Serializable]
    class CentralGaz : ICentral, IProductionFlexible
    {
        private int production;
        private int coutProd;
        private int co2prod;

        public int getProd()
        {
            return production;
        }

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
            return String.Format("Je produis {0} W par seconde, je coute {1} euro par W produit et je polue {2} co2 par secondes", production, coutProd, co2prod);
        }
    }

    interface IDepandantMeteo
    {
        int MeteoFavorable();
        int MeteoDefavorable();
        int MeteoNoEff();

    }

    [Serializable]
    class CentralEolien : CentreControle,ICentral, IDepandantMeteo, IWeatherObserver
    {
        private int production;
        private int coutProd;
        private int co2prod;
        private float temperature;

        public int getProd()
        {
            return production;
        }



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

            else
            {
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
            return String.Format("Je suis une centrale Eolienne qui produis {0} W par seconde, je coute {1} euro par W produit et je polue {2} co2 par secondes", production, coutProd, co2prod);
        }
    }

    [Serializable]
    class CentralSolaire : ICentral
    {
        private int production;
        public int getProd()
        {
            return production;
        }

        public virtual String GetInfo()
        {
            return String.Format("bientot je serais interessant");
        }
    }

    [Serializable]
    class CentralAcheteur : ICentral
    {
        private int production;
        public int getProd()
        {
            return production;
        }
        public virtual String GetInfo()
        {
            return String.Format("bientot je serais interessant");
        }
    }

    [Serializable]
    class CentralNucl : ICentral
    {
        private int production;
        public int getProd()
        {
            return production;
        }

        public virtual String GetInfo()
        {
            return String.Format("Bientot moi aussi je serai interessant");
        }
    }

    public class CentralFactory: CentreControle
    {
        public static ICentral Build(string res, int a, int b, int c)
        {

            switch (res.ToLower())
            {
                case "gaz":
                    return new CentralGaz(a, b, c);
                case "nuclaire":
                    return new CentralNucl();
                case "eolien":
                    return new CentralEolien(a, b, c);
                case "solaire":
                    return new CentralSolaire();
                default:
                    return new CentralAcheteur();

            }
        }
    }
    public interface IConsumer
    {
        String GetElectricalConsommation();
    }

    public class ConsumerFactory: CentreControle
    {
        public static IConsumer Build(string t, string name, int conso)
        {
            switch (t.ToLower())
            {
                case "city":
                    return new ConsumerCity(name, conso);
                case "country":
                    return new ConsumerCountry(name, conso);
                case "entreprise":
                    return new ConsumerEntreprise(name, conso);
                case "dissipator":
                    return new ConsumerDissipator(name, conso);
                default:
                    return new ConsumerForeign(name, conso);

            }
        }

    }

    [Serializable]
    class ConsumerCity : IConsumer
    {
        private string cityName;
        private int ElectricConsommation;

        public ConsumerCity(string city, int consom)
        {
            this.cityName = city;
            this.ElectricConsommation = consom;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("La ville est : {0} , elle a une consommation électrique de {1}", cityName, ElectricConsommation);
        }
    }

    [Serializable]
    class ConsumerCountry : IConsumer
    {
        private string countryName;
        private int ElectricConsommation;
        public ConsumerCountry(string name, int conso)
        {
            this.countryName = name;
            this.ElectricConsommation = conso;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("La  {0} a une consommation électrique de {1}", countryName, ElectricConsommation);
        }
    }

    [Serializable]
    class ConsumerDissipator : IConsumer
    {
        private string securityMachine;
        private int maxConsommation;
        public ConsumerDissipator(string name, int conso)
        {
            this.securityMachine = name;
            this.maxConsommation = conso;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("La  {0} a une consommation électrique de {1}", securityMachine, maxConsommation);
        }
    }

    [Serializable]
    class ConsumerEntreprise : IConsumer
    {
        private string entrepriseName;
        private int ElectricConsommation;
        public ConsumerEntreprise(string entreprise, int conso)
        {
            this.entrepriseName = entreprise;
            this.ElectricConsommation = conso;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("L'entreprise {0} a une consommation électrique de {1}", entrepriseName, ElectricConsommation);
        }
    }

    [Serializable]
    class ConsumerForeign : IConsumer
    {
        private string name;
        private int ElectricDemand;
        public ConsumerForeign(string n, int e)
        {
            this.name = n;
            this.ElectricDemand = e;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("La  {0} a une consommation électrique de {1}", name, ElectricDemand);
        }
    }




}
