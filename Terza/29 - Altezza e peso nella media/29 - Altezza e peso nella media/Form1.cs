using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29___Altezza_e_peso_nella_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVerifica_Click(object sender, EventArgs e)
        {
            byte H = Convert.ToByte(txtA.Text);
            int W = Convert.ToInt16(txtP.Text);
            bool Media = ((H >= 155 && H <= 195) && (W >= 60 && W <= 100));

            if (Media)
                MessageBox.Show("Nella media");
            else
                MessageBox.Show("NON nella media");
        }
    }
}
