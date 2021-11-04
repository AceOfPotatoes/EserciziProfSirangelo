using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15___Reali_in_ordine_crescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtN1.Text);
            double N2 = Convert.ToDouble(txtN2.Text);

            if(N1 > N2)
            {
                lblMaggiore.Text = N1.ToString();
                lblMinore.Text = N2.ToString();
            }
            else
            {
                lblMaggiore.Text = N2.ToString();
                lblMinore.Text = N1.ToString();
            }
        }
    }
}
