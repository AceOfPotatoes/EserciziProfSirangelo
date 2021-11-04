using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10___Troncamenti_e_approssimazione_num_reale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(txtX.Text);
            double IntPrec;
            double IntSucc;
            double IntAppr;

            IntPrec = Math.Truncate(X);
            IntSucc = IntPrec + 1;
            IntAppr = Math.Round(X);

            lblPrecedente.Text = IntPrec.ToString();
            lblSuccessivo.Text = IntSucc.ToString();
            lblApprossimato.Text = IntAppr.ToString();
        }
    }
}
