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

namespace _68___DataTable_libri_da_modificare_e_salvare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {           
            CreaColonne();
            CreaRighe();
            ImpostaDGV();            
        }

        private void plsSalva_Click(object sender, EventArgs e)
        {
            Salva();            
        }

        private void CreaColonne()
        {
            dt.Columns.Add("Titolo");
            dt.Columns.Add("Artista");
            dt.Columns.Add("Casa Editrice");
            dt.Columns.Add("Anno");
            dt.Columns.Add("Prezzo");
        }

        private void CreaRighe()
        {
            StreamReader FR = File.OpenText("Libri.txt");

            while (!FR.EndOfStream)
            {
                DataRow R = dt.NewRow();

                R["Titolo"] = FR.ReadLine();
                R["Artista"] = FR.ReadLine();
                R["Casa Editrice"] = FR.ReadLine();
                R["Anno"] = FR.ReadLine();
                R["Prezzo"] = FR.ReadLine();
              
                dt.Rows.Add(R);
            }

            FR.Close();
        }

        private void ImpostaDGV()
        {
            dgv.DataSource = dt;
            dgv.ReadOnly = false;
        }

        private void Salva()
        {
            StreamWriter FW = File.CreateText("Libri.txt");

            for(int k = 0; k < dt.Rows.Count; k++)
            {
                FW.WriteLine(dt.Rows[k]["Titolo"]);
                FW.WriteLine(dt.Rows[k]["Artista"]);
                FW.WriteLine(dt.Rows[k]["Casa Editrice"]);
                FW.WriteLine(dt.Rows[k]["Anno"]);
                FW.WriteLine(dt.Rows[k]["Prezzo"]);
            }

            FW.Close();
        }

        
    }
}
