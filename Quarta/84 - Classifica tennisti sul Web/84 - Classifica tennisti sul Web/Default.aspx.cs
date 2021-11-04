using System;
using System.Collections.Generic;
using System.IO;

namespace _84___Classifica_tennisti_sul_Web
{
    public partial class Default : System.Web.UI.Page
    {
        List<string> Nominativi;
        List<int> Punteggi;

        protected void Page_Load(object sender, EventArgs e)
        {
            Nominativi = new List<string>();
            Punteggi = new List<int>();

            LeggiFile();
            Ordina();
            Visualizza();
        }
        protected void lnkModifica_Click(object sender, EventArgs e)
        {
            string Nominativo = "";
            string RigaSelezionata = lstTennisti.Items[lstTennisti.SelectedIndex].ToString();
            Nominativo = RigaSelezionata.Substring(0, RigaSelezionata.IndexOf(':'));
            Response.Redirect("/ModificaPunteggio.aspx?Nominativo="+Nominativo);
        }

        protected void lnkRimuovi_Click(object sender, EventArgs e)
        {
            string Nominativo = "";
            string RigaSelezionata = lstTennisti.Items[lstTennisti.SelectedIndex].ToString();
            Nominativo = RigaSelezionata.Substring(0, RigaSelezionata.IndexOf(':'));
            Response.Redirect("/EliminaTennista.aspx?Nominativo=" + Nominativo);
        }

        protected void lnkNuovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("/NuovoTennista.aspx");
        }

        private void LeggiFile()
        {
            StreamReader FR = File.OpenText(Server.MapPath("Tennisti.txt"));

            while (!FR.EndOfStream)
            {
                Nominativi.Add(FR.ReadLine());
                Punteggi.Add(int.Parse(FR.ReadLine()));               
            }

            FR.Close();
        }

        private void Ordina()
        {
            for(int k1 = 0; k1 < Nominativi.Count-1; k1++)
            {
                int PosMax = k1;
                for(int k2 = k1+1; k2<Nominativi.Count; k2++)
                {
                    if (Punteggi[k2] > Punteggi[PosMax])
                        PosMax = k2;
                }
                string NominativoTemp = Nominativi[k1];
                int PunteggioTemp = Punteggi[k1];

                Nominativi[k1] = Nominativi[PosMax];
                Punteggi[k1] = Punteggi[PosMax];

                Nominativi[PosMax] = NominativoTemp;
                Punteggi[PosMax] = PunteggioTemp;
            }
        }

        private void Visualizza()
        {
            for (int k = 0; k < Nominativi.Count; k++)
                lstTennisti.Items.Add(Nominativi[k] + ":" + Punteggi[k]);
        }
    }
}