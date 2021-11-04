using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _64___Vocali_e_consonanti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsControlla_Click(object sender, EventArgs e)
        {
            string St1 = txtFrase.Text;
            string St2 = "";
            string St3 = "";

            for(int K = 0; K <= St1.Length-1; K++)
            {
                if (St1[K] == 'A' || St1[K] == 'E' || St1[K] == 'I' || St1[K] == 'O' || St1[K] == 'U')
                    St2 += St1[K];
                
                else
                    St3 += St1[K];
            }

            lblConsonanti.Text = St3;
            lblVocali.Text = St2;
        }
    }
}
