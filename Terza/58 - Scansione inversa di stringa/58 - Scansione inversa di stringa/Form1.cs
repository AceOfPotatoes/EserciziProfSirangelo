using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.VisualBasic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58___Scansione_inversa_di_stringa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsStart_Click(object sender, EventArgs e)
        {
            string Str = Interaction.InputBox("Scrivi qui la tua parola");

            for (int K = Str.Length - 1; K >= 0; K--)
                MessageBox.Show(Str[K].ToString());
        }
    }
}
