using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Segnaposto_su_caselle
{
    class Percorso
    {

        private int[] Vet = new int[100];

        public Percorso() { }
        
        public int[] VetPercorso
        {
            get { return Vet; }
            set { Vet = value; }
        }

        public void CreaPercorso(ListView lstPercorso)
        {
            Random R = new Random();

            foreach(int k in Vet)
            {
                Vet[k] = 0;
            }

            int i = 0;
            int NumeroGenerato;
            while (i <= 20)
            {
                NumeroGenerato = R.Next(100);
                if (Vet[NumeroGenerato] == 0)
                {
                    Vet[NumeroGenerato] = R.Next(1, 10);
                    i++;
                }
            }

            for(int k = 0; k<100; k++)
            {
                if (Vet[k] == 0)
                    lstPercorso.Items.Add("Casella " + (k + 1));
                else
                    lstPercorso.Items.Add("Trappola " + Vet[k]);
            }
        }
    }
}
