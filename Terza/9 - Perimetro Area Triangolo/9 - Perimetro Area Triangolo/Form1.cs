using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9___Perimetro_Area_Triangolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int C1;
        int C2;
        double P;
        int A;
       

        private void button1_Click(object sender, EventArgs e)
        {
            C1 = Convert.ToInt32(txtC1.Text);
            C2 = Convert.ToInt32(txtC2.Text);
            A = (C1 * C2) / 2;
            P = C1 + C2 + Math.Sqrt(C1 ^ 2 + C2 ^ 2);
            P = Math.Round(P, 3);
            lblArea.Text = A.ToString();
            lblPerimetro.Text = P.ToString();
        }
    }
}
