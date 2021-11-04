using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17___Stato_fisico_acqua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double T = Convert.ToDouble(txtT.Text);

            if (T <= 0)
            {
                MessageBox.Show("L'acqua è allo stato solido");
            }
            else
            {
                if (T >= 100)
                {
                    MessageBox.Show("L'acqua è allo stato gassoso");
                }
                else
                {
                    MessageBox.Show("L'acqua è allo stato liquido");
                }
                
            }
        }
    }
}
