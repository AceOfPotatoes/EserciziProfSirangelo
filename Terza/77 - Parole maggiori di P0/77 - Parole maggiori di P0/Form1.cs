using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _77___Parole_maggiori_di_P0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtP0.Text, txtP.Text) > 0)
                lblMaggiori.Text += txtP.Text + ":";    
        }       
    }
}
