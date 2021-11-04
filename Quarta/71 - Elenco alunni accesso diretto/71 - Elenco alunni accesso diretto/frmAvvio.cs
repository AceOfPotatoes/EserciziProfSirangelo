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

namespace _71___Elenco_alunni_accesso_diretto
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        /* Struttura record:
         * Num matricola (int): 4 byte
         * Cognome (string): 20+1 byte
         * Nome (string): 20+1 byte
         * Classe (string): 3+1 byte
         * Media voti (float): 4 byte    
         * Lunghezza record = 4+21+21+4+4 = 54 byte
         */

        FileStream F;
        BinaryReader BR;
        BinaryWriter BW;

        const int DimRecord = 54;
        int N = 0;
        int Pos = 0;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            F = File.Open("Alunni.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BR = new BinaryReader(F);
            BW = new BinaryWriter(F);
            N = (int)F.Length / DimRecord;
            numPos.Minimum = 0;
            numPos.Maximum = 0;
            if(N==0)
                plsAlunnoInPos.Enabled = false;
            lblNumAlunni.Text = N.ToString();
        }

        private void plsAggiungiAlunno_Click(object sender, EventArgs e)
        {
            F.Seek(N * DimRecord, SeekOrigin.Begin);

            BW.Write(Convert.ToInt32(txtID.Text));
            BW.Write(txtNome.Text.PadRight(20));
            BW.Write(txtCognome.Text.PadRight(20));
            BW.Write(txtClasse.Text.ToUpper().PadRight(3));
            BW.Write((float)Math.Round(Convert.ToSingle(txtMediaVoti.Text), 1));
            
            N = (int)F.Length / DimRecord;
            lblNumAlunni.Text = N.ToString();
            numPos.Maximum = N-1;

            ReimpostaControlli();
        }

        private void ReimpostaControlli()
        {
            txtID.Clear();
            txtNome.Clear();
            txtCognome.Clear();
            txtClasse.Clear();
            txtMediaVoti.Clear();
            txtID.Focus();
        }

        private void txtClasse_TextChanged(object sender, EventArgs e)
        {
            if (txtClasse.Text.Length > 3)
                txtClasse.Text = "";
        }

        private void plsAlunnoInPos_Click(object sender, EventArgs e)
        {
            Pos = (int)numPos.Value;

            F.Seek(Pos * DimRecord, SeekOrigin.Begin);

            lblAlunnoInPos.Text = "";

            lblAlunnoInPos.Text += "ID: " + BR.ReadInt32();
            lblAlunnoInPos.Text += (char)13 + "Nome: " + BR.ReadString() + (char)13;
            lblAlunnoInPos.Text += "Cognome: " + BR.ReadString() + (char)13;
            lblAlunnoInPos.Text += "Classe: " + BR.ReadString() + (char)13;
            lblAlunnoInPos.Text += "Media voti: " + BR.ReadSingle();
        }

        private void plsChiudi_Click(object sender, EventArgs e)
        {
            F.Close();
            Application.Exit();
        }

        private void plsRicercaClasse_Click(object sender, EventArgs e)
        {
            lstAlunni.Items.Clear();
            string Classe = txtClasseRicerca.Text.ToUpper();

            for(int k=0; k<N; k++)
            {
                F.Seek(k * DimRecord + 4, SeekOrigin.Begin);
                string Nominativo = BR.ReadString() + BR.ReadString();
                string ClasseAlunno = BR.ReadString();
                if (Classe == ClasseAlunno)
                    lstAlunni.Items.Add(Nominativo);
            }
        }

        private void txtClasseRicerca_TextChanged(object sender, EventArgs e)
        {
            if (txtClasse.Text.Length > 3)
                txtClasse.Text = "";
        }
    }
}
