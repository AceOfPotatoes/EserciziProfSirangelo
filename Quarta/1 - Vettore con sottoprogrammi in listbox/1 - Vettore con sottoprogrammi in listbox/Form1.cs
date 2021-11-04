using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1___Vettore_con_sottoprogrammi_in_listbox
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        int[] Vet;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            Vet = new int[5];
        }

        private void plsInizia_Click(object sender, EventArgs e)
        {
            int P = 0;

            if(txtP.Text != "")
            {
                P = Convert.ToInt32(txtP.Text);
            }
            else
            {
                MessageBox.Show("Per favore inserire un numero nella casella di testo");
            }

            Riempi(P);
            Visualizza();
        }

        private void Riempi(int P)
        {
            for(int k = 0; k<5; k++)
            {
                Vet[k] = P;
                P++;
            }
        }

        private void Visualizza()
        {
            lstV.Items.Clear();
            for(int k = 0; k<5; k++)
            {
                lstV.Items.Add(Vet[k]);
            }
        }


    }
}
