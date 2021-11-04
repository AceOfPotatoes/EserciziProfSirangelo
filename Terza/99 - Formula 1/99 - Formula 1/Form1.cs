using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _99___Formula_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int NumPiloti = Convert.ToInt16(Interaction.InputBox("Quanti piloti hai?"));
            string Pilota;

            for(int K = 0; K <= NumPiloti-1; K++)
            {
                Pilota = Interaction.InputBox("Dammi il nome del pilota");
                lstPiloti.Items.Add(Pilota);
                cmbPiloti.Items.Add(Pilota);
            }
        }

        private void plsAvanza_Click(object sender, EventArgs e)
        {
            if (lstPiloti.SelectedIndex == -1)
                MessageBox.Show("Nessun pilota selezionato", "ERRORE");
            else
                if (lstPiloti.SelectedIndex == 0)
                    MessageBox.Show("Il pilota è già in prima posizione", "Impossibile avanzare");
                else
                {
                    string ScambioLst = lstPiloti.Items[lstPiloti.SelectedIndex - 1].ToString();

                    lstPiloti.Items[lstPiloti.SelectedIndex - 1] = lstPiloti.Items[lstPiloti.SelectedIndex];
                    lstPiloti.Items[lstPiloti.SelectedIndex] = ScambioLst;

                    string ScambioCmb = cmbPiloti.Items[lstPiloti.SelectedIndex - 1].ToString();

                    cmbPiloti.Items[lstPiloti.SelectedIndex - 1] = cmbPiloti.Items[lstPiloti.SelectedIndex];
                    cmbPiloti.Items[lstPiloti.SelectedIndex] = ScambioCmb;
            }         
        }

        private void plsArretra_Click(object sender, EventArgs e)
        {
            if (lstPiloti.SelectedIndex == -1)
                MessageBox.Show("Nessun pilota selezionato", "ERRORE");
            else
                if (lstPiloti.SelectedIndex == lstPiloti.Items.Count-1)
                MessageBox.Show("Il pilota è già in ultima posizione", "Impossibile arretrare");
            else
            {
                string Scambio = lstPiloti.Items[lstPiloti.SelectedIndex].ToString();

                lstPiloti.Items[lstPiloti.SelectedIndex] = lstPiloti.Items[lstPiloti.SelectedIndex + 1];
                lstPiloti.Items[lstPiloti.SelectedIndex + 1] = Scambio;

                string ScambioCmb = cmbPiloti.Items[lstPiloti.SelectedIndex].ToString();

                cmbPiloti.Items[lstPiloti.SelectedIndex] = cmbPiloti.Items[lstPiloti.SelectedIndex + 1];
                cmbPiloti.Items[lstPiloti.SelectedIndex + 1] = ScambioCmb;
            }
        }

        private void plsRitira_Click(object sender, EventArgs e)
        {
            string Ritirato = lstPiloti.Items[lstPiloti.SelectedIndex].ToString();
            cmbPiloti.Items.RemoveAt(lstPiloti.SelectedIndex);
            lstPiloti.Items.RemoveAt(lstPiloti.SelectedIndex);
            lstRitirati.Items.Add(Ritirato);
        }

        private void plsPunteggio_Click(object sender, EventArgs e)
        {
            int Posizione = cmbPiloti.SelectedIndex;
            int Punteggio; 

            switch (Posizione)
            {
                case 0:
                    Punteggio = 25;
                    break;

                case 1:
                    Punteggio = 18;
                    break;

                case 2:
                    Punteggio = 15;
                    break;

                case 3:
                    Punteggio = 12;
                    break;

                case 4:
                    Punteggio = 10;
                    break;

                case 5:
                    Punteggio = 8;
                    break;

                case 6:
                    Punteggio = 6;
                    break;

                case 7:
                    Punteggio = 4;
                    break;

                case 8:
                    Punteggio = 2;
                    break;

                case 9:
                    Punteggio = 1;
                    break;

                default:
                    Punteggio = 0;
                    break;                                              
            }

            MessageBox.Show("Il punteggio del pilota selezionato attualmente sarebbe: " + Punteggio.ToString(), "PUNTEGGIO");
        }

        private void plsTermina_Click(object sender, EventArgs e)
        {
            int Punteggio;
            for (int K = 0; K <= lstPiloti.Items.Count-1; K++)
            {
                switch (K)
                {
                    case 0:
                        Punteggio = 25;
                        break;

                    case 1:
                        Punteggio = 18;
                        break;

                    case 2:
                        Punteggio = 15;
                        break;

                    case 3:
                        Punteggio = 12;
                        break;

                    case 4:
                        Punteggio = 10;
                        break;

                    case 5:
                        Punteggio = 8;
                        break;

                    case 6:
                        Punteggio = 6;
                        break;

                    case 7:
                        Punteggio = 4;
                        break;

                    case 8:
                        Punteggio = 2;
                        break;

                    case 9:
                        Punteggio = 1;
                        break;

                    default:
                        Punteggio = 0;
                        break;
                }

                lstPiloti.Items[K] = (K + 1).ToString() + "° " + lstPiloti.Items[K] + " - " +Punteggio.ToString() +" Punti";
            }
            MessageBox.Show("Gara terminata, puoi visualizzare nella lista posizioni e punteggi", "ATTENZIONE");
        }
    }
}
