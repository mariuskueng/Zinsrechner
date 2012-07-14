using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Zinsrechner2010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (String PrinterName in PrinterSettings.InstalledPrinters)
                comboBox1.Items.Add(PrinterName);
            comboBox1.Text = printDocument1.PrinterSettings.PrinterName;
            txtbox_Anfangskapital2.Text = "4500";
            txtbox_ZinsProzent2.Text = "5";
            txtbox_Anfangskapital3.Text = "4500";
            txtbox_ZinsCHF3.Text = "225";
            textBox1.Text = "225";
            textBox2.Text = "5";
        }
        private void Zinsrechner2010_Load(object sender, EventArgs e)
        {
            //foreach (String PrinterName in PrinterSettings.InstalledPrinters)
            //    comboBox1.Items.Add(PrinterName);
            //comboBox1.Text = printDocument1.PrinterSettings.PrinterName;
        }
        private void btn_Rechnen_Click(object sender, EventArgs e)
        {
            //Anfangskapital holen
            //1st to get the string values in the textboxes
            string sAnfangskapital = txtbox_Anfangskapital3.Text;
            //then to convert it to integer/double
            double dAnfangskapital = double.Parse(sAnfangskapital);
            //Zins holen
            //1st to get the string values in the textboxes
            string sZins = txtbox_ZinsCHF3.Text;
            //then to convert it to integer/double
            double dZins = double.Parse(sZins);
            double Resultat = ((100 / dAnfangskapital) * dZins);
            //Labeländerung Zinsfuss
            string Zinsfuss = txtbox_ZinsProzent.Text;
            Zinsfuss = Resultat.ToString();
            txtbox_ZinsProzent.Text = Zinsfuss;
            //MessageBox.Show("Resultat = " + Resultat);
        }

        private void toolstrip_Beenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolstrip_DruckenAlles_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dZinssatz = 0;
            //Zinssatz holen
            //1st to get the string values in the textboxes
            string sZins = textBox2.Text;
            //then to convert it to integer/double
            dZinssatz = double.Parse(sZins);
            //Zins1Jahr holen
            //1st to get the string values in the textboxes
            string sZinsCHF = textBox1.Text;
            //then to convert it to integer/double
            double dZins = double.Parse(sZinsCHF);
            double Resultat = ((100 / dZinssatz) * dZins);
            //Labeländerung Anfangskapital
            string Anfangskapital = txtbox_Anfangskapital.Text;
            Anfangskapital = Resultat.ToString();
            txtbox_Anfangskapital.Text = Anfangskapital;
            //MessageBox.Show("Resultat = " + Resultat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dKapital = 0;
            double dZinssatz = 0;

            //Kapital holen
            //1st to get the string values in the textboxes
            string sKapital = txtbox_Anfangskapital2.Text;
            //then to convert it to integer/double
            dKapital = double.Parse(sKapital);



            //Zinssatz holen
            //1st to get the string values in the textboxes
            string sZins = txtbox_ZinsProzent2.Text;
            //then to convert it to integer/double
            dZinssatz = double.Parse(sZins);

            //Berechnen
            double dZins = (dKapital / 100) * dZinssatz;//1. Zins wird ausgerechnet
            double dEndkapital = (dZins + dKapital);
            //Labeländerung Kapital Ende
            string sEnde1 = txtbox_Endkapital2.Text;
            sEnde1 = dEndkapital.ToString();
            txtbox_Endkapital2.Text = sEnde1;
            //Labeländerung Gesamtzins
            string sGesamtzins = txtbox_ZinsCHF2.Text;
            sGesamtzins = dZins.ToString();
            txtbox_ZinsCHF2.Text = sGesamtzins;
            //MessageBox.Show("Zins 1. Jahr: " + d1Zins + "\nGesamtzins: " + dGesamtzins + "\nNeues Kapital: " + dKapitalneu1);

            //MessageBox.Show(sKapital + "\n" + sZins);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument2.DefaultPageSettings.PrinterSettings.PrinterName = comboBox1.Text;
            printDocument2.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           //geht nicht hab unten einen neuen drucker gemacht!
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            //Überschrift:
            e.Graphics.DrawString("Zinsrechner", new Font("Arial", 16, FontStyle.Bold), new SolidBrush(Color.Black), 10, 20);

            //Zinsberechnung:
            e.Graphics.DrawString("Zinsberechnung", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 10, 30);
            e.Graphics.DrawString("Anfangskapital: " + txtbox_Anfangskapital2.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 40);
            e.Graphics.DrawString("Zinssatz in %: " + txtbox_ZinsProzent2.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 45);
            e.Graphics.DrawString("Endkapital: " + txtbox_Endkapital2.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 50);
            e.Graphics.DrawString("Zins: " + txtbox_ZinsCHF2.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 55);

            //Kapitalberechnung:
            e.Graphics.DrawString("Kapitalberechnung", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 10, 65);
            e.Graphics.DrawString("Zins: " + textBox1.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 75);
            e.Graphics.DrawString("Zinssatz in %: " + textBox2.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 80);
            e.Graphics.DrawString("Anfangskapital: " + txtbox_Anfangskapital.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 85);
            
            //Zinsfussberechnung:
            e.Graphics.DrawString("Zinsfussberechnung", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 10, 95);
            e.Graphics.DrawString("Anfangskapital: " + txtbox_Anfangskapital3.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 105);
            e.Graphics.DrawString("Zins: " + txtbox_ZinsCHF3.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 110);
            e.Graphics.DrawString("Zinssatz in %: " + txtbox_ZinsProzent.Text, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 115);

        }
    }
}
