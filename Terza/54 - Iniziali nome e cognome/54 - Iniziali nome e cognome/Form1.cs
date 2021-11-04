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

        private void plsIniziali_Click(object sender, EventArgs e)
        {
            lblRis.Text = txtNome.Text[0].ToString() + "." + textBox1.Text[0].ToString() + ".";
        }
    }
}
