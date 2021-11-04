using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _87___Numeri_primi_fino_ad_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsMostra_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtN.Text);         //Numero col quale terminiamo la ricerca di numeri primi

            for (int i = 2; i <= N; i++)                //for che gestisce i numeri da scansionare, fino ad N (Con i che viene scansionato dalla funzione)
            {              
                if (NumeroPrimo(i))                     //La funzione restituisce semplicemente true o false, dipendentemente se il numero sia primo o meno.
                {
                    MessageBox.Show(i.ToString());
                }
            }
        }

        private bool NumeroPrimo(int N)
        {
            /*Questo for scansiona tutti i numeri da 2 (primo numero primo) ad N.
              Se trova un numero (che è per forza < N) che è divisibile per N, prima della fine del ciclo
              vuol dire che N -> e quindi i, non può essere primo */

            for (int k = 2; k < N; k++)                  
            {
                if (N % k == 0)
                {
                    return false;                    
                }                  
            }
            return true;           
        }
    }
}
