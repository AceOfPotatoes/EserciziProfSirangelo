using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void plsCalcola_Click(object sender, EventArgs e)
        {

            int X = 0;

            X = Convert.ToInt32(txtLato.Text);

            X = X * 4;
            lblPerimetro.Text = X.ToString();

        }
    }
}
