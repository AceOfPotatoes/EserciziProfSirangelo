using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___Promosso_o_bocciato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            int V = Convert.ToSByte(txtV.Text);

            if (V >= 6)
            {
                MessageBox.Show("L'alunno è promosso");
            }
            else
            {
                if (V < 0)
                {
                    MessageBox.Show("Non è possibile avere valutazioni minori di 0");
                }
                else
                {
                    MessageBox.Show("L'alunno è bocciato");
                }
            }

        }
    }
}
