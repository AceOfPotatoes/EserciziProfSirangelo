using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30___Controllo_anno_bisestile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt16(txtA.Text);
            bool DivQuattro = (A % 4 == 0);
            bool DivCento = (A % 100 == 0);
            bool DivQuattrocento = (A % 400 == 0);
            bool Bisestile = (((DivQuattro && DivCento) && DivQuattrocento) || (DivQuattro && !DivCento));

            if (Bisestile)
                MessageBox.Show("L'anno in questione è bisestile");
            else
                MessageBox.Show("L'anno in questione NON è bisestile");
        }
    }
}
