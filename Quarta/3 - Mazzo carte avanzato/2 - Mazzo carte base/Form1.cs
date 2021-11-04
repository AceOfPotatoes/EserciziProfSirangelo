using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace _2___Mazzo_carte_base
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        string[] Vet;
        int N = 10;

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            Vet = new string[10];
            AggiungiCarteComboBox();           
            AggiungiPaloComboBox();
            cmbPali.SelectedIndex = 0;
            cmbCarte.SelectedIndex = 0;
        }

        private void plsInizia_Click(object sender, EventArgs e)
        {
            Inserisci();
            plsOrdina.Visible = true;
        }

        private void plsConta_Click(object sender, EventArgs e)
        {
            char CartaDaContare = Convert.ToChar(cmbCarte.SelectedItem);
            int Conto = 0;
            for (int k = 0; k < N; k++)
            {
                if (Vet[k][0] == CartaDaContare)
                    Conto++;
            }

            if (Conto == 1)
                MessageBox.Show("All'interno del vettore la carta è presente " + Conto.ToString() + " volta", "Calcolo Carta");
            else
                MessageBox.Show("All'interno del vettore la carta è presente " + Conto.ToString() + " volte", "Calcolo Carta");
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            char P = Convert.ToChar(cmbPali.SelectedItem);
            StessoPalo(P);
        }

        private void plsRimuovi_Click(object sender, EventArgs e)
        {
            Rimuovi();
        }

        private void plsOrdina_Click(object sender, EventArgs e)
        {
            string[] VetNumerico;
            VetNumerico = new string[10];

            CreaVetNumerico(ref VetNumerico);
            Array.Sort(VetNumerico);
            RiportaInOrdine(VetNumerico);
        }

        private void Inserisci()
        {
            string DaInserire = "";
            bool Valido = false;
            bool Presente = false;
            for (int k = 0; k < 10; k++)
            {
                DaInserire = Interaction.InputBox("Inserire una carta").ToUpper();
                Valido = ControlloCarta(DaInserire);
                Presente = false;
                if (Valido)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (DaInserire == Vet[j])
                            Presente = true;
                    }
                    if (!Presente)
                        Vet[k] = DaInserire;
                    else
                    {
                        MessageBox.Show("LA CARTA INSERITA E' GIA' PRESENTE", "ATTENZIONE!");
                        k--;                        
                    }
                    Visualizza(k);
                }
                else
                {
                    MessageBox.Show("CARTA INSERITA NON VALIDA", "ATTENZIONE");
                    k--;
                }                
            }
        }

        private void Visualizza(int k)
        {
            lstCarte.Items.Clear();

            for(int j = 0; j <= k && j<10; j++)            
                lstCarte.Items.Add(Vet[j]);            
        }

        private bool ControlloCarta(string DaInserire)
        {
            if (DaInserire.Length != 2)
                return false;
            else
            {
                switch (DaInserire[0])
                {
                    case 'A': break;
                    case '0': break;
                    case '1': break;
                    case '2': break;
                    case '3': break;
                    case '4': break;
                    case '5': break;
                    case '6': break;
                    case '7': break;
                    case 'D': break;
                    case 'C': break;
                    case 'R': break;
                    default: return false;
                }

                switch (DaInserire[1])
                {                    
                    case 'B': break;
                    case 'C': break;
                    case 'D': break;
                    case 'S': break;
                    default: return false;
                }
            }
            return true;
        }

        private void AggiungiCarteComboBox()
        {
            cmbCarte.Items.Add('A');
            cmbCarte.Items.Add('2');
            cmbCarte.Items.Add('3');
            cmbCarte.Items.Add('4');
            cmbCarte.Items.Add('5');
            cmbCarte.Items.Add('6');
            cmbCarte.Items.Add('7');
            cmbCarte.Items.Add('D');
            cmbCarte.Items.Add('C');
            cmbCarte.Items.Add('R');
        }

        private void AggiungiPaloComboBox()
        {
            cmbPali.Items.Add('B');
            cmbPali.Items.Add('C');
            cmbPali.Items.Add('D');
            cmbPali.Items.Add('S');
        }

        private void StessoPalo(char P)
        {
            lstPalo.Items.Clear();
            for(int k = 0; k < 10; k++)            
                if (Vet[k][1] == P)
                    lstPalo.Items.Add(Vet[k]);           
        }

        private void Rimuovi()
        {
            int Indice = lstCarte.SelectedIndex;
            if(Indice >= 0)
            {
                for(int k = Indice; k < N-1; k++)
                {
                    string Temp = Vet[k];
                    Vet[k] = Vet[k + 1];
                    Vet[k + 1] = Temp;
                }
                N--;
            }

            lstCarte.Items.Clear();
            for(int k = 0; k < N; k++)
            {
                lstCarte.Items.Add(Vet[k]);
            }
        }

        private void CreaVetNumerico(ref string[] VetNumerico)
        {
            for (int k = 0; k < 10; k++)
            {
                switch (Vet[k][0])
                {
                    case 'A': VetNumerico[k] = "0" + Vet[k][1]; break;
                    case '2': VetNumerico[k] = "1" + Vet[k][1]; break;
                    case '3': VetNumerico[k] = "2" + Vet[k][1]; break;
                    case '4': VetNumerico[k] = "3" + Vet[k][1]; break;
                    case '5': VetNumerico[k] = "4" + Vet[k][1]; break;
                    case '6': VetNumerico[k] = "5" + Vet[k][1]; break;
                    case '7': VetNumerico[k] = "6" + Vet[k][1]; break;
                    case 'D': VetNumerico[k] = "7" + Vet[k][1]; break;
                    case 'C': VetNumerico[k] = "8" + Vet[k][1]; break;
                    case 'R': VetNumerico[k] = "9" + Vet[k][1]; break;
                }
            }
        }

        private void RiportaInOrdine(string[] VetNumerico)
        {
            lstCarte.Items.Clear();
            for (int k = 0; k < 10; k++)
            {
                switch (VetNumerico[k][0])
                {
                    case '0': Vet[k] = "A" + Vet[k][1]; break;
                    case '1': Vet[k] = "2" + Vet[k][1]; break;
                    case '2': Vet[k] = "3" + Vet[k][1]; break;
                    case '3': Vet[k] = "4" + Vet[k][1]; break;
                    case '4': Vet[k] = "5" + Vet[k][1]; break;
                    case '5': Vet[k] = "6" + Vet[k][1]; break;
                    case '6': Vet[k] = "7" + Vet[k][1]; break;
                    case '7': Vet[k] = "D" + Vet[k][1]; break;
                    case '8': Vet[k] = "C" + Vet[k][1]; break;
                    case '9': Vet[k] = "R" + Vet[k][1]; break;
                }
                lstCarte.Items.Add(Vet[k]);
            }
        }
    }
}
