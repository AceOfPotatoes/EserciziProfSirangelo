using System.Windows.Forms;

namespace _13___Statistiche_partita_con_proprietà_classi
{
    class Partita
    {
        private string sq1;
        private string sq2;
        private int gol1;
        private int gol2;

        public Partita()
        {
            sq1 = "XD";
            sq2 = "LOL";
            gol1 = 0;
            gol2 = 0;
        }

        public string Sq1
        {
            get { return sq1; }
            set { sq1 = value; }
        }

        public string Sq2
        {
            get { return sq2; }
            set { sq2 = value; }
        }

        public int Gol1
        {
            get { return gol1; }
            set { gol1 = value; }
        }

        public int Gol2
        {
            get { return gol2; }
            set { gol2 = value; }
        }

        public string Totocalcio()
        {
            if (gol1 > gol2)
                return "1";
            else
            {
                if (gol1 == gol2)
                    return "X";
                else
                    return "2";
            }               
        }

        public string SquadraVincitrice(TextBox txtSq1, TextBox txtSq2)
        {
            if (Totocalcio() == "1")
                return "La squadra vincitrice è " + txtSq1.Text;
            else
            {
                if (Totocalcio() == "X")
                    return "La partita è finita in pareggio!";
                else
                    return "La squadra vincitrice è " + txtSq2.Text;
            }
        }

        public int SommaGol()
        {
            return (gol1 + gol2); 
        }
    }
}
