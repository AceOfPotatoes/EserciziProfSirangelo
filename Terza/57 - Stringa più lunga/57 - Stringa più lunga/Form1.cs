using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57___Stringa_più_lunga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string St1 = txtSt1.Text;
            string St2 = txtSt2.Text;

            if (St1.Length > St2.Length)
                MessageBox.Show("La stringa più lunga è " + St1, "RISULTATO");

            else
                
            if (St1.Length == St2.Length)
                    MessageBox.Show("Le due stringhe hanno la medesima lunghezza", "RISULUTATO");

                else
                    MessageBox.Show("La stringa più lunga è " + St2, "RISULTATO");

        }
    }
}
