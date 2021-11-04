using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _67___DataTable_alunni_di_una_classe_specificata
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        private void plsCercaClasse_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            CreaColonne(ref dt);
            CreaRighe(ref dt);
            ImpostaDGV(ref dt);
        }

        private void CreaColonne(ref DataTable dt)
        {
            dt.Columns.Add("Cognome");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Sesso");
            dt.Columns.Add("Classe");
            dt.Columns.Add("Età");
        }

        private void CreaRighe(ref DataTable dt)
        {
            StreamReader F = File.OpenText("Dati.txt");

            while (!F.EndOfStream)
            {
                DataRow R = dt.NewRow();

                R["Cognome"] = F.ReadLine();
                R["Nome"] = F.ReadLine();
                R["Sesso"] = F.ReadLine();
                string Classe = F.ReadLine();
                R["Classe"] = Classe;
                R["Età"] = F.ReadLine();

                if (Convert.ToByte(Classe) == (byte)numClasse.Value)
                    dt.Rows.Add(R);
            }

            F.Close();
        }

        private void ImpostaDGV(ref DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
        }
    }
}
