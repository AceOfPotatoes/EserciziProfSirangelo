using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _95___Lista_numeri_reali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double> ListaN;

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaN = new List<double>();
        }

        //Aggiungi
        private void button1_Click(object sender, EventArgs e)
        {
            ListaN.Add(Convert.ToDouble(txtElemento.Text));
        }

        //Maggiori di X
        private void button2_Click(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(txtX.Text);
            lblMaggioriX.Text = "";
            for (int i = 0; i < ListaN.Count; i++)
            {
                if(ListaN[i] > X)
                {
                    lblMaggioriX.Text += ListaN[i].ToString() + "/";
                }               
            }
        }

        private void plsSomma_Click(object sender, EventArgs e)
        {
            double Somma = 0;
            for(int i = 0; i < ListaN.Count; i++)
            {
                Somma += ListaN[i];
            }
            lblSomma.Text = Somma.ToString();
        }

        private void plsMedia_Click(object sender, EventArgs e)
        {
            double Media = 0;
            double Somma = 0;
            for (int i = 0; i < ListaN.Count; i++)
            {
                Somma += ListaN[i];
            }
            Media = Somma / ListaN.Count;
            lblMedia.Text = Media.ToString();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            lblElementi.Text = "";
            for (int i = 0; i < ListaN.Count; i++)
            {
                lblElementi.Text += ListaN[i].ToString() + "/";
            }
        }
    }
}
