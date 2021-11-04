using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.VisualBasic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _96___Lista_di_interi_con_accorgimenti
{
    public partial class Form1 : Form
    {
        List<int> ListaN;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaN = new List<int>();
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtN.Text);
            bool Presente = false; 
            if(ListaN.Count == 0)
            {
                ListaN.Add(N);
            }
            else
            {
                for(int i = 0; i < ListaN.Count; i++)
                {
                    if (ListaN[i] == N)
                    {
                        Presente = true;
                        break;
                    }
                }
                if(Presente == false)
                {
                    ListaN.Add(N);
                }
            }
            txtN.Text = "";
            txtN.Focus();
        }

        private void plsSostituisci_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtSostituto.Text);
            int Pos = Convert.ToInt32(Interaction.InputBox("Inserisci qui la posizione dove vuoi andare a sostituire questo numero"));
            ListaN[Pos] = N;
            txtSostituto.Text = "";
            txtSostituto.Focus();
        }

        private void plsRimuovi_Click(object sender, EventArgs e)
        {
            int X = Convert.ToInt16(txtRimuovi.Text);
            for(int i = 0; i < ListaN.Count; i++)
            {
                if(ListaN[i] == X)
                {
                    ListaN.RemoveAt(i);
                }
            }
            txtRimuovi.Text = "";
            txtRimuovi.Focus();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            lblElementi.Text = "";
            for(int i = ListaN.Count-1; i >= 0; i--)
            {
                lblElementi.Text += ListaN[i].ToString() + "-";
            }
        }

        private void plsSvuota_Click(object sender, EventArgs e)
        {
            ListaN.Clear();
            lblElementi.Text = "";
        }
    }
}
