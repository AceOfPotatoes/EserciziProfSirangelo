using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsRosso_Click(object sender, EventArgs e)
        {
            lblColore.Text = "Rosso";
            lblColore.ForeColor = Color.White;
            lblColore.BackColor = Color.Red;
        }

        private void plsVerde_Click(object sender, EventArgs e)
        {
            lblColore.Text = "Verde";
            lblColore.ForeColor = Color.White;
            lblColore.BackColor = Color.Green;
        }

        private void plsBlu_Click(object sender, EventArgs e)
        {
            lblColore.Text = "Blu";
            lblColore.ForeColor = Color.White;
            lblColore.BackColor = Color.Blue;
        }

        private void plsGiallo_Click(object sender, EventArgs e)
        {
            lblColore.Text = "Giallo";
            lblColore.ForeColor = Color.Black;
            lblColore.BackColor = Color.Yellow;
        }

        private void plsNero_Click(object sender, EventArgs e)
        {
            lblColore.Text = "Nero";
            lblColore.ForeColor = Color.White;
            lblColore.BackColor = Color.Black;
        }
    }
}
