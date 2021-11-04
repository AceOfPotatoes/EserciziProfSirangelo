using System;
using System.Collections.Generic;
using System.IO;

namespace _84___Classifica_tennisti_sul_Web
{
    public partial class EliminaTennista : System.Web.UI.Page
    {
        List<string> Nominativi;
        List<int> Punteggi;

        protected void Page_Load(object sender, EventArgs e)
        {
            Nominativi = new List<string>();
            Punteggi = new List<int>();

            lblNominativo.Text = Request.QueryString["Nominativo"];
        }

        protected void plsAnnulla_Click(object sender, EventArgs e)
        {
            Homepage();
        }

        private void Homepage()
        {
            Response.Redirect("/Default.aspx");
        }

        protected void plsElimina_Click(object sender, EventArgs e)
        {
            /*La menzione al prof. negli esercizi sul tennis è OBBLIGATORIA
            * PASSWORD: danielesirangelo */
            string Password = txtPassword.Text;

            if (Password == "danielesirangelo")
            {
                lblEsito.Text = "";

                LeggiFile();
                Rimuovi(lblNominativo.Text);
                ScriviFile();

                Homepage();
            }
                else
                    lblEsito.Text = "PASSWORD ERRATA";
        }

        private void Rimuovi(string Nominativo)
        {
            int Pos = 0;

            while (Nominativi[Pos] != Nominativo && Pos < Nominativi.Count)
                Pos++;

            Nominativi.RemoveAt(Pos);
            Punteggi.RemoveAt(Pos);
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

        private void ScriviFile()
        {
            StreamWriter FW = File.CreateText(Server.MapPath("Tennisti.txt"));

            for (int k = 0; k < Nominativi.Count; k++)
            {
                FW.WriteLine(Nominativi[k]);
                FW.WriteLine(Punteggi[k]);
            }

            FW.Close();
        }
    }
}