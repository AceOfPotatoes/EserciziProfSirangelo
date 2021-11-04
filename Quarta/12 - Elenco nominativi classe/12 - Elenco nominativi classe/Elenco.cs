using System;
using System.Windows.Forms;

namespace _12___Elenco_nominativi_classe
{
    class Elenco
    {
        private string[] Nominativi = new string[20];
        private int N = 0;

        public Elenco()
        {
        }

        public void Aggiungi(string Nome)
        {
            Nominativi[N] = Nome.ToUpper();
            N++;
        }

        public void Rimuovi(int Pos)
        {
            for(int k = Pos; k < N-1; k++)
            {
                string Temp = Nominativi[k];
                Nominativi[k] = Nominativi[k + 1];
                Nominativi[k + 1] = Temp;
            }
            N--;
        }

        public void Ordina()
        {
            for(int k1 = 0; k1 < N-1; k1++)
            {
                int PosMin = k1;
                for(int k2 = k1+1; k2 < N; k2++)
                {
                    if(string.CompareOrdinal(Nominativi[k2], Nominativi[k1]) < 0)
                        PosMin = k2;
                }
                string Temp = Nominativi[k1];
                Nominativi[k1] = Nominativi[PosMin];
                Nominativi[PosMin] = Temp;
            }
        }

        public void Visualizza(ListBox Elenco)
        {
            Elenco.Items.Clear();
            for (int k = 0; k < N; k++)            
                Elenco.Items.Add(Nominativi[k]);            
        }
    }
}
