using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _78___Confronto_di_N_parole_e_P_con_ordinale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsInizia_Click(object sender, EventArgs e)
        {
            string P0 = txtP.Text;
            string P1 = null;
            string PMaj = null;
            int N = Convert.ToInt16(txtN.Text);
            int K = 0;
          

            while (K < N)
            {
                P1 = Interaction.InputBox("Inserisci qui la parola che vuoi confrontare");
                
                if(PMaj == null)
                {
                    if (string.CompareOrdinal(P0, P1) < 0)
                    {
                        PMaj += P1;
                    }
                }
                else
                {
                    if (string.CompareOrdinal(P0, P1) < 0)
                    {
                        PMaj += "-" + P1;
                    }
                }
                                  
                K++;
            }
         
            lblMaggiori.Text = PMaj;
        }
    }
}
