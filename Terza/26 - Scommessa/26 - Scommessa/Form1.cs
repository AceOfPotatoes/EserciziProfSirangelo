using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26___Scommessa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            byte A = Convert.ToByte(txtA.Text);
            byte B = Convert.ToByte(txtB.Text);

            if(A > B || (A+B) > 4)
            {
                MessageBox.Show("La scommessa è vincente");
            }
            else
            {
                MessageBox.Show("La scommessa è perdente");
            }
        }
    }
}
