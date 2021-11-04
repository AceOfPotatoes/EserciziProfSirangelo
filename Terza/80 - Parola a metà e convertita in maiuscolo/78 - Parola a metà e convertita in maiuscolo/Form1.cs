using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _78___Stringa_a_metà_e_convertita_in_maiuscolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string P = txtP.Text;
            string M1 = P.Substring(0, P.Length / 2);
            string M2 = P.Substring(P.Length / 2, P.Length / 2);
                
            MessageBox.Show(M1.ToUpper(), "PRIMA META'");
            MessageBox.Show(M2.ToUpper(), "SECONDA META'");
        }
    }
}
