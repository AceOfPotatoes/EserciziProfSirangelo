using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _84___Classifica_tennisti_sul_Web
{
    public partial class ModificaPunteggio : System.Web.UI.Page
    {
        List<string> Nominativi;
        List<int> Punteggi;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Nominativi = new List<string>();
            Punteggi = new List<int>();
            
            lblNominativo.Text = Request.QueryString["Nominativo"];
        }

        protected void plsModifica_Click(object sender, EventArgs e)
        {
            /*La menzione al prof. negli esercizi sul tennis è OBBLIGATORIA
             * PASSWORD: danielesirangelo */
            string Nominativo = lblNominativo.Text;
            string NuovoPunteggio = txtNuovoPunteggio.Text;
            string Password = txtPassword.Text;
            if (NuovoPunteggio != "")
            {
                if (Password == "danielesirangelo")
                {
                    lblEsito.Text = "";
                    LeggiFile();

                    ModificaFileTesto(Nominativo, NuovoPunteggio);

                    Homepage();
                }
                else
                    lblEsito.Text = "PASSWORD ERRATA";
            }
            else
                lblEsito.Text = "NESSUN PUNTEGGIO";
                

        }

        private void ModificaFileTesto(string Nominativo, string Punteggio)
        {
            StreamWriter FW = File.CreateText(Server.MapPath("Tennisti.txt"));

            for (int k = 0; k < Nominativi.Count; k++)
            {
                if(Nominativi[k] == Nominativo)
                {
                    FW.WriteLine(Nominativi[k]);
                    FW.WriteLine(Punteggio);
                }
                else
                {
                    FW.WriteLine(Nominativi[k]);
                    FW.WriteLine(Punteggi[k]);
                }
            }               

            FW.Close();
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

        protected void plsAnnulla_Click(object sender, EventArgs e)
        {
            Homepage();
        }

        private void Homepage()
        {
            Response.Redirect("/Default.aspx");
        }
    }
}