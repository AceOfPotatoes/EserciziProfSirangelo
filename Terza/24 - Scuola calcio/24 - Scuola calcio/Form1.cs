using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24___Scuola_calcio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            byte E = Convert.ToByte(txtAnni.Text);
            
            if(E >= 6 && E<= 18)
            {
                MessageBox.Show("Il ragazzo è iscrivibile!");
            }
            else
            {
                MessageBox.Show("Il ragazzo non è iscrivibile!");
            }
        }
    }
}
