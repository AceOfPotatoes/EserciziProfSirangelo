using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33___Eventi_orario
{
    public partial class frmOrario : Form
    {
        public frmOrario()
        {
            InitializeComponent();
        }

        Orario O1;
        bool ErroreVerificato;

        private void GestisciOraErrata(object sender, EventArgs e)
        {
            MessageBox.Show("L'ora non è accettabile");
            ErroreVerificato = true;
        }

        private void GestisciMinutiErrati(object sender, EventArgs e)
        {
            MessageBox.Show("I minuti non sono accettabili");
            ErroreVerificato = true;
        }

        private void frmOrario_Load(object sender, EventArgs e)
        {
            O1 = new Orario();
            O1.OraErrata += GestisciOraErrata;
            O1.MinutiErrati += GestisciMinutiErrati;
        }

        private void plsMezzanotte_Click(object sender, EventArgs e)
        {
            ErroreVerificato = false;
            O1.Ora = int.Parse(txtOra.Text);
            O1.Minuti = int.Parse(txtMinuti.Text);
            
            if (!ErroreVerificato)
            {
                MessageBox.Show("Dall'orario inserito a mezzanotte intercorrono: " + O1.MinutiAMezzanotte() + " minuti", "RISULTATO");
            }
            
        }
    }
}
