using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _82___Dati_studenti_sul_Web
{
    public partial class SecondaPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Classe = Request.QueryString["Classe"].ToLower();

            if (Classe != null && Classe.Length == 3)
            {
                StreamReader FR = File.OpenText(Server.MapPath("Studenti.txt"));

                while (!FR.EndOfStream)
                {
                    string Nome = FR.ReadLine();
                    string Cognome = FR.ReadLine();

                    if (FR.ReadLine() == Classe)
                        lstAlunni.Items.Add(Nome + " " + Cognome);
                }
            }
            else
                lblClasse.Text = "NESSUN PARAMETRO VALIDO RICEVUTO";
        }
    }
}