using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsArcobaleno_Click(object sender, EventArgs e)
        {
            lblRosso.BackColor = Color.Red;
            lblArancione.BackColor = Color.Orange;
            lblGiallo.BackColor = Color.Yellow;
            lblVerde.BackColor = Color.Green;
            lblBlu.BackColor = Color.Blue;
            lblIndaco.BackColor = Color.Indigo;
            lblVioletto.BackColor = Color.DarkViolet;
        }
    }
}
