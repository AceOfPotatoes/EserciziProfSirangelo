using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _94___Lista_di_nomi
{
    public partial class Form1 : Form
    {
        List<string> ListaNomi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaNomi = new List<string>();
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            ListaNomi.Add(txtNome.Text);
            lblNomi.Text = "";
            for(int i = 0; i < ListaNomi.Count; i++)
            {
                lblNomi.Text += ListaNomi[i] + ",";
            }        
        }

        private void plsRimuovi_Click(object sender, EventArgs e)
        {
            ListaNomi.RemoveAt(Convert.ToInt16(txtPos.Text));
            lblNomi.Text = "";
            for (int i = 0; i < ListaNomi.Count; i++)
            {
                lblNomi.Text += ListaNomi[i] + ",";
            }
        }

        private void plsSvuota_Click(object sender, EventArgs e)
        {
            ListaNomi.Clear();
            lblNomi.Text = "";
            for (int i = 0; i < ListaNomi.Count; i++)
            {
                lblNomi.Text += ListaNomi[i] + ",";
            }
        }           
    }
}
