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

namespace _63___Parola_senza_lettera_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsInizia_Click(object sender, EventArgs e)
        {
            string St1 = Interaction.InputBox("Inserisci qui la tua parola");
            string St2 = "";

            for(int K = 0; K <= St1.Length-1; K++)
            {
                if(St1[K] != 'A')
                {
                    St2 += St1[K];
                }
                    
                           
                
            }

            MessageBox.Show("La parola priva di \"A\" verrebbe scritta " +St2 ,"Ecco la parola");
        }
    }
}
