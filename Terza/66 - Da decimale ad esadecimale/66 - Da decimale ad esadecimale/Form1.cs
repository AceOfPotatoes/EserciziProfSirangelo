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

namespace _66___Da_decimale_ad_esadecimale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsStart_Click(object sender, EventArgs e)
        {
            string St = Interaction.InputBox("Inserisci qui il tuo numero decimale");
            string StFine = "";
            int Num = Convert.ToInt32(St);

            while(Num != 0)
            {
                switch(Num % 16)
                {
                    case 10: 
                        StFine = "A" + StFine;
                        break;

                    case 11:
                        StFine = "B" + StFine;
                        break;

                    case 12:
                        StFine = "C" + StFine;
                        break;

                    case 13:
                        StFine = "D" + StFine;
                        break;

                    case 14:
                        StFine = "E" + StFine;
                        break;

                    case 15:
                        StFine = "F" + StFine;
                        break;

                    default:
                        StFine = Convert.ToString(Num % 16) + StFine;
                        break;

                }

                Num /= 16;

            }                    
            MessageBox.Show("Il numero in ESADECIMALE è " +StFine, "RISULTATO");
        }
    }
}
