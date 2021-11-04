using System;
using System.IO;

namespace _80___Squadre_Serie_A_sul_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AggiornaDDL();
        }

        private bool Presente(string Squadra)
        {
            for (int k = 0; k < ddlSquadre.Items.Count; k++)
            {
                if (Squadra == ddlSquadre.Items[k].ToString())
                    return true;
            }
            return false;
        }

        private void AggiornaDDL()
        {
            StreamReader FR = File.OpenText(Server.MapPath("Giocatori.txt"));
            while (!FR.EndOfStream)
            {
                FR.ReadLine();
                FR.ReadLine();
                FR.ReadLine();
                string SquadraLetta = FR.ReadLine();

                if (!Presente(SquadraLetta))
                    ddlSquadre.Items.Add(SquadraLetta);
            }

            FR.Close();
        }

        protected void plsVisualizza_Click(object sender, EventArgs e)
        {
            lstFormazione.Items.Clear();
            StreamReader FR = File.OpenText(Server.MapPath("Giocatori.txt"));
            string Squadra = ddlSquadre.Text;
            while (!FR.EndOfStream)
            {
                string Cognome = FR.ReadLine();
                string Nome = FR.ReadLine();
                string Numero = FR.ReadLine();
                string SquadraLetta = FR.ReadLine();

                if (SquadraLetta == Squadra)
                    lstFormazione.Items.Add(Numero + " - " + Nome + " " + Cognome);
            }

            FR.Close();
        }

        protected void plsAggiungi_Click(object sender, EventArgs e)
        {
            string Cognome = txtCognome.Text;
            string Nome = txtNome.Text;
            string Numero = txtNumero.Text;
            string Squadra = txtSquadra.Text;

            StreamWriter FW = File.AppendText(Server.MapPath("Giocatori.txt"));

            FW.WriteLine(Cognome);
            FW.WriteLine(Nome);
            FW.WriteLine(Numero);
            FW.WriteLine(Squadra);

            FW.Close();
            AggiornaDDL();
        }
    }
}