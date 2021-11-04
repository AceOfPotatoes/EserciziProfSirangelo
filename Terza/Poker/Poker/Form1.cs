using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form1 : Form
    {
        List<string> Mazzo;
        List<string> G1;
        List<string> G2;
        List<string> G3;
        List<string> G4;

        Random R = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mazzo = new List<string>();
            G1 = new List<string>();
            G2 = new List<string>();
            G3 = new List<string>();
            G4 = new List<string>();
            CreaMazzo();

            CreaMano(G1);
            CreaMano(G2);
            CreaMano(G3);
            CreaMano(G4);

            lblG1.Text = StringaMano(G1);
            lblG2.Text = StringaMano(G2);
            lblG3.Text = StringaMano(G3);
            lblG4.Text = StringaMano(G4);
        }

        private void CreaMazzo()
        {
            string Seme = "";
            string Carta = "";
            for(int ks = 0; ks <= 3; ks++)
            {
                for(int kn = 1; kn <= 13; kn++)
                {
                    Seme = RestituisciSeme(ks);
                    Carta = RestituisciCarta(kn);
                    Mazzo.Add(Carta + Seme);
                }
            }
        }

        private string RestituisciSeme(int Num)
        {
            switch (Num)
            {
                case 0: return "C";
                case 1: return "Q";
                case 2: return "F";
                case 3: return "P";
                default: MessageBox.Show("NUMERO SEME NON VALIDO", "ERRORE INTERNO"); return "";
            }
        }

        private string RestituisciCarta(int Num)
        {
            switch (Num)
            {
                case 1: return "A";
                case 2: return "2";
                case 3: return "3";
                case 4: return "4";
                case 5: return "5";
                case 6: return "6";
                case 7: return "7";
                case 8: return "8";
                case 9: return "9";
                case 10: return "0";
                case 11: return "J";
                case 12: return "Q";
                case 13: return "K";
                default: MessageBox.Show("NUMERO CARTA NON VALIDO", "ERRORE INTERNO"); return "";
            }
        }

        private void CreaMano(List<string> Mano)
        {
            int NumCas = 0;
            for(int k = 0; k <= 4; k++)
            {
                NumCas = R.Next(Mazzo.Count);
                Mano.Add(Mazzo[NumCas]);
                Mazzo.RemoveAt(NumCas);
            }
        }

        private string StringaMano(List<string> Mano)
        {
            string St = "";
            for(int k = 0; k <= Mano.Count-1; k++)
            {
                St += Mano[k] + " ";
            }
            return St;
        }

        private void plsScambio_Click(object sender, EventArgs e)
        {
            CambiaCarte(G1, 1);
            lblG1.Text = StringaMano(G1);
            CambiaCarte(G2, 2);
            lblG2.Text = StringaMano(G2);
            CambiaCarte(G3, 3);
            lblG3.Text = StringaMano(G3);
            CambiaCarte(G4, 4);
            lblG4.Text = StringaMano(G4);

            if (eCoppia(G1))
                MessageBox.Show("G1 ha fatto coppia!!!");

            if (eCoppia(G2))
                MessageBox.Show("G2 ha fatto coppia!!!");

            if (eCoppia(G3))
                MessageBox.Show("G3 ha fatto coppia!!!");

            if (eCoppia(G4))
                MessageBox.Show("G4 ha fatto coppia!!!");
        }

        private void CambiaCarte(List<string> Mano, int Giocatore)
        {
            int PosCarta = 0;
            for (int k = 0; k <= Mano.Count-1; k++)
            {
                if(StatoCheckBox(Giocatore, k))
                {
                    PosCarta = R.Next(Mazzo.Count);
                    Mano[k] = Mazzo[PosCarta];
                    Mazzo.RemoveAt(PosCarta);
                }
            }
        }

        private bool StatoCheckBox(int Giocatore, int Pos)
        {
            switch (Giocatore)
            {
                case 1: switch (Pos)
                    {
                        case 0: return chkG1Uno.Checked;
                        case 1: return chkG1Due.Checked;
                        case 2: return chkG1Tre.Checked;
                        case 3: return chkG1Quattro.Checked;
                        case 4: return chkG1Cinque.Checked;
                        default: return false;
                    }

                case 2:
                    switch (Pos)
                    {
                        case 0: return chkG2Uno.Checked;
                        case 1: return chkG2Due.Checked;
                        case 2: return chkG2Tre.Checked;
                        case 3: return chkG2Quattro.Checked;
                        case 4: return chkG2Cinque.Checked;
                        default: return false;
                    }

                case 3:
                    switch (Pos)
                    {
                        case 0: return chkG3Uno.Checked;
                        case 1: return chkG3Due.Checked;
                        case 2: return chkG3Tre.Checked;
                        case 3: return chkG3Quattro.Checked;
                        case 4: return chkG3Cinque.Checked;
                        default: return false;
                    }

                case 4:
                    switch (Pos)
                    {
                        case 0: return chkG4Uno.Checked;
                        case 1: return chkG4Due.Checked;
                        case 2: return chkG4Tre.Checked;
                        case 3: return chkG4Quattro.Checked;
                        case 4: return chkG4Cinque.Checked;
                        default: return false;
                    }
                default: return false;               
            }
        }

       private bool eCoppia(List<string> Mano)
        {
            for (int k0 = 0; k0 <= Mano.Count-2; k0++)
            {
                for (int k1 = k0+1; k1 <= Mano.Count - 1; k1++)
                {
                    if(Mano[k0][0] == Mano[k1][0])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

 /*       private List<string> OrdinaMano(List<string> Mano)
        {
            List<string> ListaOrdinata = new List<string>();

            for(int k = 0; k <= Mano.Count-1; k++)
            {
                if(Mano[k][0])
            }
        }
        */
    }
}

