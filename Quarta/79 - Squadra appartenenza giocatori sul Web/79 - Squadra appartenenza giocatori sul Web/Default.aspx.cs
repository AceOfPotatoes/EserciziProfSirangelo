using System;
using System.IO;

namespace _79___Squadra_appartenenza_giocatori_sul_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                lblMessaggio.Text = "Archivio squadre calciatori";
            else
                lblMessaggio.Text = "BENVENUTO nell'archivio squadre calciatori";
        }

        protected void plsRicerca_Click(object sender, EventArgs e)
        {
            string Nominativo = txtNominativo.Text;
            lblSquadra.Text = "";

            StreamReader FR = File.OpenText(Server.MapPath("Calciatori.txt"));
            while (!FR.EndOfStream)
            {
                string SquadraLetta = FR.ReadLine();
                string NominativoLetto = FR.ReadLine();

                if (Nominativo == NominativoLetto)
                    lblSquadra.Text = SquadraLetta;

            }

            if (lblSquadra.Text == "")
                lblSquadra.Text = "GIOCATORE NON TROVATO";

            FR.Close();
        }
    }
}