using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjtInfoBA3_2
{
    public partial class Form1 : Form
    {

        private List<ICentral> visuel = new List<ICentral>();
        private List<IConsumer> visuel2 = new List<IConsumer>();

        private String nomFichier = "sauvegarde";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestrictionAjout();
            
            Object obj = Serialise.Recup(nomFichier);
            if(obj != null)
            {
                visuel = (List<ICentral>)obj;
            }


        }

        private void MajLstInfo()
        {
            lstInfo.Items.Clear();
            lstInfo2.Items.Clear();

            foreach (ICentral unElem in visuel)
            {
                lstInfo.Items.Add(unElem.GetInfo());
            }
            foreach (IConsumer unElem2 in visuel2)
            {
                lstInfo2.Items.Add(unElem2.GetElectricalConsommation());
            }

            Serialise.Sauve(nomFichier, visuel);
            Serialise.Sauve(nomFichier, visuel2);
        }

        private void btnAjouter(object sender, EventArgs e)
        {
            ICentral controle;
            IConsumer controle2;
            if (rdoCentrale.Checked)
            {
                controle = CentralFactory.Build(txtCreer.Text, int.Parse(txtProduction.Text), int.Parse(txtCoutProd.Text), int.Parse(txtPol.Text));
                visuel.Add(controle);

            }
            else
            {
                controle2 = ConsumerFactory.Build(txtCreer.Text, txtNom.Text, int.Parse(txtConsomation.Text));
                visuel2.Add(controle2);
            }

            MajLstInfo();

        }

        private void RestrictionAjout()
        {
            label2.Visible = rdoCentrale.Checked;
            txtProduction.Visible = rdoCentrale.Checked;
            label3.Visible = rdoCentrale.Checked;
            txtCoutProd.Visible = rdoCentrale.Checked;
            label4.Visible = rdoCentrale.Checked;
            txtPol.Visible = rdoCentrale.Checked;


            label6.Visible = !rdoCentrale.Checked;
            txtConsomation.Visible = !rdoCentrale.Checked;
            label7.Visible = !rdoCentrale.Checked;
            txtNom.Visible = !rdoCentrale.Checked;
        }

        private void rdoCentrale_CheckedChanged(object sender, EventArgs e)
        {
            RestrictionAjout();
        }

        private void rdoConso_CheckedChanged(object sender, EventArgs e)
        {
            RestrictionAjout();
        }
    }
}
