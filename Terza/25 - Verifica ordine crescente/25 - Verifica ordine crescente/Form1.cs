using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25___Verifica_ordine_crescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txtA.Text);
            int B = Convert.ToInt32(txtB.Text);
            int C = Convert.ToInt32(txtC.Text);

            if(C > B && B > A)
            {
                MessageBox.Show("I numeri sono ordinati in ordine crescente");
            }
            else
            {
                MessageBox.Show("I numeri NON sono ordinati in ordine crescente");
            }
        }
    }
}
