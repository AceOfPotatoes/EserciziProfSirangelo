using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsSole_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OGGI C'E' IL SOLE");
        }

        private void plsNuvoloso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OGGI E' NUVOLOSO");
        }

        private void plsPioggia_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("OGGI STA PIOVENDO");
        }
    }
}
