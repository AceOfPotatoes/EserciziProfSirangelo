using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsOrdinale_Click(object sender, EventArgs e)
        {
            if (string.CompareOrdinal(txtP1.Text, txtP2.Text) < 0)      //"elisabetta" viene prima di "elìsa" 
                MessageBox.Show("Viene prima " + txtP1.Text);

            else
                MessageBox.Show("Viene prima " + txtP2.Text);
        }

        private void plsNonOrdinale_Click(object sender, EventArgs e)
        {
            if(string.Compare(txtP1.Text, txtP2.Text) < 0)              //"elìsa" viene prima di "elisabetta"
                MessageBox.Show("Viene prima " + txtP1.Text);

            else
                MessageBox.Show("Viene prima " + txtP2.Text);

        }
    }
}
