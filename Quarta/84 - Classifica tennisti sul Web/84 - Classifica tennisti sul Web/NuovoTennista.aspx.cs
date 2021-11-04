using System;
using System.IO;

namespace _84___Classifica_tennisti_sul_Web
{
    public partial class NuovoTennista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void plsAnnulla_Click(object sender, EventArgs e)
        {
            Homepage();
        }

        private void Homepage()
        {
            Response.Redirect("/Default.aspx");
        }

        protected void plsAggiungi_Click(object sender, EventArgs e)
        {
            lblEsito.Text = "";

            string Nominativo = txtNominativo.Text;
            string Punteggio = txtPunteggio.Text;
            if(txtPassword.Text == "danielesirangelo")
            {
                if (Nominativo != "" && Punteggio != "")
                {
                    StreamWriter FW = File.AppendText(Server.MapPath("Tennisti.txt"));

                    FW.WriteLine(Nominativo);
                    FW.WriteLine(Punteggio);

                    FW.Close();
                    Homepage();
                }
                else
                    lblEsito.Text = "ERRORE; MANCANO DEI PARAMETRI!";
            }
            else
                lblEsito.Text = "PASSWORD ERRATA";
        }
    }
}