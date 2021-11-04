using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32___Differenza_date_con_multiform
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        frmInputData F1 = new frmInputData();
        frmInputData F2 = new frmInputData();


        private void plsInputPrimaData_Click(object sender, EventArgs e)
        {
            F1.Show();
        }

        private void plsInputSecondaData_Click(object sender, EventArgs e)
        {
            F2.Show();
        }

        private void plsCalcola_Click(object sender, EventArgs e)
        {
            lblGiorniIntercorsi.Text = F1.miaData.GiorniCheIntercorronoDa(F2.miaData).ToString();
        }

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            F1.HaModificato += frmPrimaData_HaModificato;
            F2.HaModificato += frmSecondaData_HaModificato;
        }

        private void frmPrimaData_HaModificato(object sender, EventArgs e)
        {
            txtPrimaData.Text = txtPrimaData.Text = F1.miaData.ToString();
        }

        private void frmSecondaData_HaModificato(object sender, EventArgs e)
        {
            txtSecondaData.Text = txtSecondaData.Text = F2.miaData.ToString();
        }
    }
}
