using System.Collections.Generic;
using System.Windows.Forms;

namespace _25___Costo_tessera_tennista_classificato
{
    class Regione
    {
        public Regione()
        { }

        private string NomReg;
        public int IndReg;
        public string NomeRegione
        {
            get { return NomReg; }
            set
            {
                NomReg = value;

                for (int k = 0; k <= ListaRegioni.Count-1; k++)
                {
                    if (ListaRegioni[k].ToUpper() == NomReg.ToUpper())
                        IndReg = k;
                }
            }
        }
        

        static List<string> ListaRegioni = new List<string>()
        {
            "Abruzzo", "Basilicata", "Calabria", "Campania", "Emilia",
            "Friuli", "Lazio", "Liguria", "Lombardia", "Marche", "Molise",
            "Piemonte", "Puglia", "Sardegna", "Sicilia", "Toscana", "Trentino",
            "Umbria", "ValleDAosta", "Veneto"
        };
  
        static public void CreaComboBoxRegioni(ComboBox cmbRegione)
        {
            for(int k = 0; k <= 19; k++)
            {
                cmbRegione.Items.Add(ListaRegioni[k]);
            }
        }

        public string RestituisciMacroarea(int NumeroRegione)
        {
            switch (NumeroRegione)
            {
                case 4: case 5: case 7: case 8: case 11: case 16: case 18: case 19: return "NORD";
                case 6: case 9: case 15: case 17: return "CENTRO";
                case 0: case 1: case 2: case 3: case 10: case 12: return "SUD";
                default: return "ISOLE";
                            
            }
        }

        /*Emilia, Friuli, Liguria, Lombardia, Piemonte, Trentino, Valledaosta, Veneto,
            Lazio, Marche, Umbria, Toscana,
            Abruzzo, Basilicata, Calabria, Campania, Molise, Puglia,
            Sardegna, Sicilia*/
    }
}
