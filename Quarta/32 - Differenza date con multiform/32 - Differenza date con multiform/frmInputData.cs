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
    public partial class frmInputData : Form
    {
        public frmInputData()
        {
            InitializeComponent();
        }

        public Data miaData = new Data();
        public event EventHandler HaModificato;

        private void plsApplica_Click(object sender, EventArgs e)
        {
            miaData.Giorno = (int)numGiorno.Value;
            miaData.Mese = (int)numMese.Value;
            miaData.Anno = (int)numAnno.Value;

            if (HaModificato != null)
                HaModificato(this, new EventArgs());
        }

        private void plsChiudi_Click(object sender, EventArgs e)
        {
            miaData.Giorno = (int)numGiorno.Value;
            miaData.Mese = (int)numMese.Value;
            miaData.Anno = (int)numAnno.Value;

            if (HaModificato != null)
                HaModificato(this, new EventArgs());

            Hide();
        }
    }
}
