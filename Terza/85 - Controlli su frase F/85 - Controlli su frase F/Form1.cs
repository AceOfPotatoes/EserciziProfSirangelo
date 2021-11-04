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

namespace _85___Controlli_su_frase_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void plsControlla_Click(object sender, EventArgs e)
        {
            string F = txtF.Text;
            char Punt = Convert.ToChar(Interaction.InputBox("Inserisci qui il segno di punteggiatura sul quale effettuare il controllo"));
            int NumA = 0;
            int NumPunt = 0;
            int NumSpaz = 0;
            F = F.ToLower();

            NumA = Controlli('a', F);
            NumPunt = Controlli(Punt, F);
            NumSpaz = Controlli(' ', F);

            lblA.Text = NumA.ToString();
            lblPunt.Text = NumPunt.ToString();
            lblSpazio.Text = NumSpaz.ToString();           
        }
        
        private int Controlli(char Car, string St)
        {
            int Ret = 0;
            
            for(int i = 0; i < St.Length; i++)
            {
                if(St[i] == Car)
                {
                    Ret++;
                }             
            }
            return Ret;
        }
    }
}
