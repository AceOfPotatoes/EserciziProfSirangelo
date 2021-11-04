using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _70___Catalogo_prodotti_con_DGV
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        DataTable DT = new DataTable();

        private void frmAvvio_Load(object sender, EventArgs e)
        {           
            ImpostaDGV();
            CreaComboBox();
            CreaDataTable();
        }

        private void CreaDataTable()
        {
            DT.Columns.Add("Id", typeof(int));
            DT.Columns.Add("Nome", typeof(string));
            DT.Columns.Add("Categoria", typeof(string));
            DT.Columns.Add("Prezzo", typeof(float));
            DT.Columns.Add("DataUscita", typeof(DateTime));
            DT.Columns.Add("Larghezza", typeof(float));
            DT.Columns.Add("Infiammabile", typeof(bool));
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            DT.Rows.Clear();

            sbyte Indice = (sbyte)cmbCategoria.SelectedIndex;
            if (Indice != -1)
            {
                string Categoria = cmbCategoria.Items[Indice].ToString();
                StreamReader FR = File.OpenText("Catalogo.txt");

                while (!FR.EndOfStream)
                {
                    DataRow R = DT.NewRow();

                    R["Id"] = int.Parse(FR.ReadLine());
                    R["Nome"] = FR.ReadLine();                     
                    R["Categoria"] = FR.ReadLine();
                    R["Prezzo"] = Convert.ToSingle(FR.ReadLine());
                    R["DataUscita"] = FR.ReadLine();
                    R["Larghezza"] = Convert.ToSingle(FR.ReadLine());
                    R["Infiammabile"] = FR.ReadLine();

                    if ((string)R["Categoria"] == Categoria)
                        AggiungiRiga(R);
                }              
            }
        }

        private void ImpostaDGV()
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.AutoGenerateColumns = false;
            dgv.ReadOnly = true;
            dgv.DataSource = DT;
        }

        private void CreaComboBox()
        {
            StreamReader FR = File.OpenText("Catalogo.txt");

            while (!FR.EndOfStream)
            {
                FR.ReadLine();
                FR.ReadLine();
                string Categoria = FR.ReadLine();
                if (!ControllaSePresente(Categoria))
                    cmbCategoria.Items.Add(Categoria);
                FR.ReadLine();
                FR.ReadLine();
                FR.ReadLine();
                FR.ReadLine();
            }

            FR.Close();
        }

        private bool ControllaSePresente(string Categoria)
        {
            for(int k = 0; k < cmbCategoria.Items.Count; k++)
                if (cmbCategoria.Items[k].ToString() == Categoria)
                    return true;

            return false;
        }
      
        private void AggiungiRiga(DataRow Riga)
        {
            DT.Rows.Add(Riga);
        }

        private void plsRicerca_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            for(int R = 0; R<dgv.Rows.Count; R++)
            {
                string NomeRiga = dgv[1, R].Value.ToString();
                if (NomeRiga.IndexOf(Nome) == 0)
                    dgv.Rows[R].Selected = true;
            }
        }
    }
}
