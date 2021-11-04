using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11___Lunghezza_e_area_circonferenza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(txtRaggio.Text);
            double L;
            double A;

            L = 2 * Math.PI * R;
            A = Math.PI * (R * R);

            L = Math.Round(L, 2);
            A = Math.Round(A, 2);

            lblLunghezza.Text = L.ToString();
            lblArea.Text = A.ToString();
           
        }
    }
}
