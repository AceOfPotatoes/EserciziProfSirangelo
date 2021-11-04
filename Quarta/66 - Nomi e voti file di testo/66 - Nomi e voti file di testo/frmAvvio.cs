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

namespace _66___Nomi_e_voti_file_di_testo
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            VisualizzaLista();
        }

        private void plsAggiungi_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                MessageBox.Show("Nessun nominativo inserito", "ATTENZIONE!!!");
            else
            {
                string Nome = txtNome.Text;
                int Voto = (int)numVoto.Value;

                StreamWriter FileNominativi = File.AppendText("Nominativi.txt");
                StreamWriter FileVoti = File.AppendText("Voti.txt");

                FileNominativi.WriteLine(Nome);
                FileVoti.WriteLine(Voto);
                FileNominativi.Close();
                FileVoti.Close();
                VisualizzaLista();
            }
        }

        private void VisualizzaLista()
        {
            lstLista.Items.Clear();
            StreamReader FileNominativi = File.OpenText("Nominativi.txt");
            StreamReader FileVoti = File.OpenText("Voti.txt");

            while (!FileNominativi.EndOfStream)
                lstLista.Items.Add(FileNominativi.ReadLine().ToString().PadRight(25) + " - " + FileVoti.ReadLine().ToString().PadLeft(2));

            FileNominativi.Close();
            FileVoti.Close();
        }

        private void plsRicerca_Click(object sender, EventArgs e)
        {
            if (txtStudente.Text == "")
                MessageBox.Show("Nessun nominativo inserito", "ATTENZIONE!!!");
            else
            {
                string Nome = txtStudente.Text;
                byte Pos = 0;

                StreamReader FileNominativi = File.OpenText("Nominativi.txt");
                while (!FileNominativi.EndOfStream)
                {
                    if (FileNominativi.ReadLine() == Nome)
                        MessageBox.Show("Il nominativo è presente e si trova in posizione: " + Pos + "; il suo voto è: " +Voto(Pos));
                    else
                        Pos++;
                }
                    
                FileNominativi.Close();
                VisualizzaLista();
            }
        }

        private int Voto(byte Pos)
        {
            StreamReader FileVoti = File.OpenText("Voti.txt");
            byte k = 0;

            while (k != Pos)
            {
                FileVoti.ReadLine();
                k++;
            }
                
            int DaRestituire = int.Parse(FileVoti.ReadLine());
            FileVoti.Close();
            return DaRestituire;
        }

        private void plsMaggiori_Click(object sender, EventArgs e)
        {
            StreamReader FileVoti = File.OpenText("Voti.txt");
            byte k = 0;

            string NominativoMaggiore = "";
            int VotoMaggiore = int.MinValue;

            while (!FileVoti.EndOfStream)
            {
                int VotoLetto = int.Parse(FileVoti.ReadLine());
                byte j = 0;
                if (VotoLetto > VotoMaggiore)
                {
                    VotoMaggiore = VotoLetto;
                    StreamReader FileNominativi = File.OpenText("Nominativi.txt");
                    while (j < k)
                    {
                        FileNominativi.ReadLine();
                        j++;
                    }
                    NominativoMaggiore = FileNominativi.ReadLine();
                    FileNominativi.Close();
                }

                k++;
            }

            FileVoti.Close();
            MessageBox.Show("Il nominativo con il relativo voto maggiore appartiene a: " + NominativoMaggiore + "; con voto: " + VotoMaggiore);

        }

        private void plsMaggioriSei_Click(object sender, EventArgs e)
        {
            StreamReader FileVoti = File.OpenText("Voti.txt");
            
            byte k = 0;
            
            string Nominativo = "";
            int VotoLetto = 0;

            while (!FileVoti.EndOfStream)
            {
                VotoLetto = int.Parse(FileVoti.ReadLine());
                byte j = 0;
                if (VotoLetto >= 6)
                {
                    StreamReader FileNominativi = File.OpenText("Nominativi.txt");
                    while (j < k)
                    {
                        
                        FileNominativi.ReadLine();
                        j++;
                    }                   
                    Nominativo = FileNominativi.ReadLine().ToString().PadRight(25);
                    FileNominativi.Close();
                    lstMaggiori.Items.Add(Nominativo + " - " + VotoLetto.ToString().PadLeft(2));
                }

                k++;
            }

            FileVoti.Close();
        }
    }
}
