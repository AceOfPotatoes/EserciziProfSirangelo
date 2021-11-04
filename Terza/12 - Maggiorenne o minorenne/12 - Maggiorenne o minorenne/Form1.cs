using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12___Maggiorenne_o_minorenne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Anni = Convert.ToSByte(txtAnni.Text);

            if(Anni >= 18)
            {
                MessageBox.Show("Maggiorenne");
            }
            else
            {
                if(Anni < 0)
                {
                    MessageBox.Show("Non è possibile avere meno di 0 anni");
                }
                else
                {
                    MessageBox.Show("Minorenne");
                }                    
            }
                
            
        }
    }
}
