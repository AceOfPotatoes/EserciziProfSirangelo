using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2___Giorno_in_data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plsVisualizza_Click(object sender, EventArgs e)
        {
            // 01/01/2000 -> Sabato


            byte GG = Convert.ToByte(txtG.Text);                //Giorno
            byte MM = Convert.ToByte(txtM.Text);                //Mese
            int AAAA = Convert.ToInt16(txtA.Text);              //Anno
            int G1;                                             //Totale giorni trascorsi
            int G2 = 0;                                         //Giorni trascorsi all'interno dell'anno inserito
            int Bis;                                            //Numero di anni bisestili nell'intervallo 2000/AAAA
            bool IsBis;                                         //False -> anno non bisestile - True -> Anno bisestile
            bool Errore = false;                                        //Se True -> ritorna all'inizio del programma 
            const int Ar = 2000;                                //Anno di riferimento


            Bis = ((AAAA - Ar) / 4) - ((AAAA - Ar) / 100) + ((AAAA - Ar) / 400);

            if (AAAA % 4 == 0)
            {
                if (AAAA % 100 == 0)
                {
                    if (AAAA % 400 == 0)
                    {
                        IsBis = true;
                    }
                    else
                    {
                        IsBis = false;
                    }
                }
                else
                {
                    IsBis = true;
                }
            }
            else
            {
                IsBis = false;
            }



            if (MM == 4 || MM == 6 || MM == 9)                  //Controllo se i giorni inseriti siano compatibili con il mese scelto
            {
                if (GG > 30)
                {
                    MessageBox.Show("Per questo mese inserire un giorno che sia ≤ 30");
                    Errore = true;
                }
                else
                {
                    if (GG > 31)
                    {
                        MessageBox.Show("Per questo mese inserire un giorno che sia ≤ 31");
                        Errore = true;
                    }
                }
            }
            else
            {
                if (IsBis)
                {
                    if(MM == 2 && GG > 29)
                    {
                        MessageBox.Show("Per il mese di febbraio (bisestile) inserire un giorno che sia ≤ 29");
                        Errore = true;
                    }
                }
                else
                {
                    if(MM == 2 && GG > 28)
                    {
                        MessageBox.Show("Per il mese di febbraio inserire un giorno che sia ≤ 28");
                        Errore = true;
                    }
                }
            }
            

            if (AAAA < 2000)
            {
                MessageBox.Show("Inserire un anno che sia ≥ al 2000");
            }
            else
            {
                if(!Errore)                                             //Se le condizioni per evitare l'errore sono state soddisfatte. Inizio col vero e proprio programma                              
                {

                    if (IsBis && (MM == 1 || MM == 2))
                    {
                        GG--;
                    }

                    switch (MM)                                         //Definisco i giorni trascorsi all'interno dell'anno inserito
                    {
                        case 1:                           
                            G2 = 0 + (GG);
                            break;

                        case 2:
                            
                                                  
                            G2 = G2 + 31 + GG;
                            break;

                        case 3:
                            G2 = G2 + 31 + 28 + GG;
                            break;

                        case 4:
                            G2 = G2 + (31 * 2) + 28 + GG;
                            break;

                        case 5:
                            G2 = G2 + (31 * 2) + 28 + 30 + GG;
                            break;

                        case 6:
                            G2 = G2 + (31 * 3) + 28 + 30 + GG;
                            break;

                        case 7:
                            G2 = G2 + (31 * 3) + 28 + (30 * 2) + GG;
                            break;

                        case 8:
                            G2 = G2 + (31 * 4) + 28 + (30 * 2) + GG;
                            break;

                        case 9:
                            G2 = G2 + (31 * 5) + 28 + (30 * 2) + GG;
                            break;

                        case 10:
                            G2 = G2 + (31 * 5) + 28 + (30 * 3) + GG;
                            break;

                        case 11:
                            G2 = G2 + (31 * 6) + 28 + (30 * 3) + GG;
                            break;

                        case 12:
                            G2 = G2 + (31 * 6) + 28 + (30 * 4) + GG;
                            break;

                        default:
                            MessageBox.Show("Inserire un mese ≤ a 12");
                            break;
                    }



                    G1 = ((AAAA - Ar) * 365) + Bis + G2;




                    switch (G1 % 7)                                             //Definisco il giorno all'interno della settimana e lo visualizzo
                    {
                        case 1:
                            MessageBox.Show("Domenica");
                            break;

                        case 2:
                            MessageBox.Show("Lunedì");
                            break;

                        case 3:
                            MessageBox.Show("Martedì");
                            break;

                        case 4:
                            MessageBox.Show("Mercoledì");
                            break;

                        case 5:
                            MessageBox.Show("Giovedì");
                            break;

                        case 6:
                            MessageBox.Show("Venerdì");
                            break;

                        default:
                            MessageBox.Show("Sabato");
                            break;
                    }
                }           
           }           
        }
    }
}
