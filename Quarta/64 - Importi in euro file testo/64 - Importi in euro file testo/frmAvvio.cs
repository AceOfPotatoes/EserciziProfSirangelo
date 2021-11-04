using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _64___Importi_in_euro_file_testo
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        StreamReader FR;
        int Num;
        List<int> ListaImporti;
        int Somma = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            FR = File.OpenText("Importi.txt");           
        }

        private void plsSomma_Click(object sender, EventArgs e)
        {
            ListaImporti = new List<int>();
            LeggiFile();

            MessageBox.Show("La somma degli importi è: " + Somma);

            FR.Close();
        }

        private void plsScrivi_Click(object sender, EventArgs e)
        {
            ListaImporti = new List<int>();

            LeggiFile();

            StreamWriter FW = File.CreateText("ImportiMaggiori100.txt");

            for(int k = 0; k < Num; k++)
            {
                if (ListaImporti[k] > 100)
                {
                    lstImporti.Items.Add(ListaImporti[k]);
                    FW.WriteLine(ListaImporti[k].ToString());
                }                   
            }

            FW.Close();
        }

        private void LeggiFile()
        {
            string RigaLetta;
            Somma = 0;
            Num = 0;

            while (!FR.EndOfStream)
            {
                RigaLetta = FR.ReadLine();
                Somma += int.Parse(RigaLetta);
                ListaImporti.Add(int.Parse(RigaLetta));
                Num++;
            }
        }
    }
}
