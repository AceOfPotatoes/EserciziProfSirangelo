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

namespace _69___DataGridView_Atleti
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            dgv.DataSource = dt;
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nominativo", typeof(string));
            dt.Columns.Add("DataNascita", typeof(DateTime));
            dt.Columns.Add("Peso", typeof(int));
            dt.Columns.Add("Altezza", typeof(float));
            dt.Columns.Add("Guadagno", typeof(int));



            
            StreamReader FR = File.OpenText("ArchivioAtleti.txt");

            while (!FR.EndOfStream)
            {
                DataRow R = dt.NewRow();
                R["Id"] = int.Parse(FR.ReadLine());
                R["Nominativo"] = FR.ReadLine();
                int Anno = int.Parse(FR.ReadLine());
                int Mese = int.Parse(FR.ReadLine());
                int Giorno = int.Parse(FR.ReadLine());
                R["DataNascita"] = new DateTime(Anno, Mese, Giorno);
                R["Peso"] = int.Parse(FR.ReadLine());
                R["Altezza"] = Convert.ToSingle(FR.ReadLine());
                R["Guadagno"] = int.Parse(FR.ReadLine());

                dt.Rows.Add(R);
            }

            FR.Close();

            

        }
    }
}
