using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace _72___Formula_1_ad_accesso_diretto
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        /* Struttura record:        
         * Nominativo (string): 30+1 byte
         * Num. pilota (byte): 1 byte
         * Scuderia (string): 20+1 byte  
         * Lunghezza record = 31+1+21 = 53
         */

        FileStream F;
        BinaryReader BR;
        BinaryWriter BW;
        DataTable DT;

        const int DimRecord = 53;
        int N = 0;
        int Pos = 0;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            F = File.Open("Gara.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BR = new BinaryReader(F);
            BW = new BinaryWriter(F);
            N = (int)F.Length / DimRecord;
            DT = new DataTable();
            DT.Columns.Add("Posizione", typeof(byte));
            DT.Columns.Add("Nominativo", typeof(string));
            DT.Columns.Add("NumeroPilota", typeof(byte));
            DT.Columns.Add("Scuderia", typeof(string));
            dgv.DataSource = DT;
            plsVisualizzaDati.Enabled = false;
            plsSorpasso.Enabled = false;
            AggiornaTabella();
            lblN.Text = N.ToString();
            numPos.Maximum = N;
            if (N > 0)
            {
                plsVisualizzaDati.Enabled = true;
                plsSorpasso.Enabled = true;
            }
        }

        private void plsAggiungiFine_Click(object sender, EventArgs e)
        {
            if(N == 0)
            {
                plsVisualizzaDati.Enabled = true;
                plsSorpasso.Enabled = true;
            }
            
            F.Seek(N*DimRecord, SeekOrigin.Begin);

            string Nominativo = txtNominativo.Text;
            byte NumPilota = (byte)numPilota.Value;
            string Scuderia = txtScuderia.Text;

            BW.Write(Nominativo.PadRight(30));
            BW.Write(NumPilota);
            BW.Write(Scuderia.PadRight(20));
            N = (int)F.Length / DimRecord;
            numPos.Maximum = N;
            AggiornaTabella();
        }

        private void AggiornaTabella()
        {
            DT.Rows.Clear();
            for (int k = 0; k < N; k++)
            {
                F.Seek(k*DimRecord, SeekOrigin.Begin);
                string Nominativo = BR.ReadString();
                byte NumPilota = BR.ReadByte();
                string Scuderia = BR.ReadString();
                DataRow R = DT.NewRow();
                R["Posizione"] = k + 1;
                R["Nominativo"] = Nominativo;
                R["NumeroPilota"] = NumPilota;
                R["Scuderia"] = Scuderia;
                DT.Rows.Add(R);
            }
        }

        private void plsChiudi_Click(object sender, EventArgs e)
        {
            F.Close();
            Application.Exit();
        }

        private void plsVisualizzaDati_Click(object sender, EventArgs e)
        {
            Pos = (int)numPos.Value;
            F.Seek((Pos-1) * DimRecord, SeekOrigin.Begin);
            string Nominativo = BR.ReadString();
            byte NumPilota = BR.ReadByte();
            string Scuderia = BR.ReadString();
            lblDatiPilota.Text = "";
            lblDatiPilota.Text += "Nominativo: " + Nominativo + (char)13;
            lblDatiPilota.Text += "Num. Pilota: " + NumPilota.ToString() + (char)13;
            lblDatiPilota.Text += "Scuderia: " + Scuderia + (char)13;
        }

        private void plsSorpasso_Click(object sender, EventArgs e)
        {
            Pos = (int)numPos.Value;
            if(Pos != 1)
            {
                F.Seek((Pos - 1) * DimRecord, SeekOrigin.Begin);
                string Nominativo = BR.ReadString();
                byte NumPilota = BR.ReadByte();
                string Scuderia = BR.ReadString();

                F.Seek((Pos - 2) * DimRecord, SeekOrigin.Begin);
                string Nominativo2 = BR.ReadString();
                byte NumPilota2 = BR.ReadByte();
                string Scuderia2 = BR.ReadString();

                F.Seek((Pos - 2) * DimRecord, SeekOrigin.Begin);
                BW.Write(Nominativo.PadRight(30));
                BW.Write(NumPilota);
                BW.Write(Scuderia.PadRight(20));

                F.Seek((Pos - 1) * DimRecord, SeekOrigin.Begin);
                BW.Write(Nominativo2.PadRight(30));
                BW.Write(NumPilota2);
                BW.Write(Scuderia2.PadRight(20));
            }
            AggiornaTabella();
        }
    }
}
