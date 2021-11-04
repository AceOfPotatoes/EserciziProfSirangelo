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

namespace P6___Unione_due_file_testo_ordinati
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        public event EventHandler FileInesistente;
        byte N;
        byte NumUnione = 0;
        StreamWriter F3;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            FileInesistente += GestisciFileInesistente;
        }

        private void GestisciFileInesistente(object sender, EventArgs e)
        {
            switch (N)
            {
                case 1:
                    MessageBox.Show("Uno.txt non trovato", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 2:
                    MessageBox.Show("Due.txt non trovato", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show("C'è un problema...", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void plsUnisci_Click(object sender, EventArgs e)
        {
            StreamReader F1;
            StreamReader F2;

            //Provo ad aprire Uno.txt
            try
            {
                F1 = File.OpenText("Uno.txt");

                //Provo ad aprire Due.txt
                try
                {
                    F2 = File.OpenText("Due.txt");

                    LeggiFiles(F1, F2);
                }
                catch
                {
                    N = 2;
                    FileInesistente(this, new EventArgs());
                }
            }
            catch
            {
                N = 1;
                FileInesistente(this, new EventArgs());
            }
        }

        private void LeggiFiles(StreamReader F1, StreamReader F2)
        {
            NumUnione = 0;
            bool PrimoMaggiore = false;
            bool SecondoMaggiore = false;
            string RigaPrimoFile = "";
            string RigaSecondoFile = "";

            while (!F1.EndOfStream && !F2.EndOfStream)
            {
                if ((!PrimoMaggiore && !SecondoMaggiore) || (PrimoMaggiore && SecondoMaggiore))
                {
                    RigaPrimoFile = F1.ReadLine();
                    RigaSecondoFile = F2.ReadLine();
                }
                else if (PrimoMaggiore && !SecondoMaggiore)
                    RigaSecondoFile = F2.ReadLine();
                else if (!PrimoMaggiore && SecondoMaggiore)
                    RigaPrimoFile = F1.ReadLine();
                
                if (string.Compare(RigaPrimoFile, RigaSecondoFile) > 0)
                {
                    SecondoMaggiore = false;    
                    PrimoMaggiore = true;
                    ScriviNome(RigaSecondoFile);
                } 
                else if(string.Compare(RigaPrimoFile, RigaSecondoFile) < 0)
                {
                    PrimoMaggiore = false;
                    SecondoMaggiore = true;
                    ScriviNome(RigaPrimoFile);
                }
                else
                {
                    PrimoMaggiore = false;
                    SecondoMaggiore = false;
                    ScriviNome(RigaPrimoFile);
                    ScriviNome(RigaSecondoFile);
                }
            }

            if (F1.EndOfStream)
            {
                string StringaFinaleUno = RigaPrimoFile;
                bool UltimoScritto = false;
                while (!F2.EndOfStream)
                {                    
                    string StringaDue = F2.ReadLine();

                    if (!UltimoScritto)
                    {
                        if (string.Compare(StringaFinaleUno, StringaDue) > 0)
                            ScriviNome(StringaDue);

                        else if (string.Compare(StringaFinaleUno, StringaDue) < 0)
                        {
                            ScriviNome(StringaFinaleUno);
                            UltimoScritto = true;
                            ScriviNome(StringaDue);
                        }

                        else
                        {
                            ScriviNome(StringaFinaleUno);
                            ScriviNome(StringaDue);
                            UltimoScritto = true;
                        }
                    }
                    else
                        ScriviNome(StringaDue);
                    
                }
            }
                               
            if (F2.EndOfStream)
            {
                string StringaFinaleDue = RigaSecondoFile;
                bool UltimoScritto = false;

                while (!F1.EndOfStream)
                {                    
                    string StringaUno = F1.ReadLine();

                    if (!UltimoScritto)
                    {
                        if (string.Compare(StringaFinaleDue, StringaUno) > 0)
                            ScriviNome(StringaUno);
                        else if (string.Compare(StringaFinaleDue, StringaUno) < 0)
                        {
                            ScriviNome(StringaFinaleDue);
                            UltimoScritto = true;
                            ScriviNome(StringaUno);
                        }
                        else
                        {
                            ScriviNome(StringaFinaleDue);
                            ScriviNome(StringaUno);
                            UltimoScritto = true;
                        }
                    }
                    else
                        ScriviNome(StringaUno);
                }
            }

            VisualizzaFile(F1, "Uno.txt", lstUno);
            VisualizzaFile(F2, "Due.txt", lstDue);
            VisualizzaFile(new StreamReader("Unione.txt"), "Unione.txt", lstUnione);
            F1.Close();
            F2.Close();
        }

        private void ScriviNome(string Nome)
        {
            if(NumUnione != 0)
            {
                F3 = File.AppendText("Unione.txt");
                F3.WriteLine(Nome); 
            }
            else
            {
                F3 = File.CreateText("Unione.txt");
                F3.WriteLine(Nome);
            }

            NumUnione++;
            F3.Close();
        }

        private void VisualizzaFile(StreamReader File, string Percorso, ListBox lst)
        {
            lst.Items.Clear();
            File = new StreamReader(Percorso);
            while (!File.EndOfStream)
                lst.Items.Add(File.ReadLine());
        }
    }
}
