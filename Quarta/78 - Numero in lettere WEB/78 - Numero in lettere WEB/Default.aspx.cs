using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _78___Numero_in_lettere_WEB
{
    public partial class Default : System.Web.UI.Page
    {
        string[] Unità = {"", "uno", "due", "tre", "quattro", "cinque", "sei", "sette", "otto", "nove", "dieci", "undici", "dodici", "tredici", "quattordici", "quindici", "sedici", "diciassette", "diciotto", "diciannove"};
        string[] Decine = { "", "", "venti", "trenta", "quaranta", "cinquanta", "sessanta", "settanta", "ottanta", "novanta" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessaggio.Enabled = true;
                lblMessaggio.Text = "Benvenuto in numero in lettere WEB, che inserito un numero tra (1,999), restituisce il suo corrispettivo in lettere";
            }
            else
                lblMessaggio.Enabled = false;
        }

        protected void plsLettere_Click(object sender, EventArgs e)
        {
            lblRisultato.Text = "";
            int N = int.MinValue;

            if (int.Parse(txtN.Text) >= 1 && int.Parse(txtN.Text) <= 999)
            {
                N = int.Parse(txtN.Text);

                if (Compreso(N, 0, 19))
                    lblRisultato.Text = AggiungiUnità(N);
                else if (Compreso(N, 20, 99))
                    lblRisultato.Text = AggiungiDecine(int.Parse(N.ToString()[0].ToString())) + AggiungiUnità(int.Parse(N.ToString()[1].ToString()));
                else if (Compreso(int.Parse(N.ToString()[1].ToString() + N.ToString()[2].ToString()), 10, 19))
                    lblRisultato.Text = AggiungiCentinaia(int.Parse(N.ToString()[0].ToString())) + AggiungiUnità(int.Parse(N.ToString()[1].ToString() + N.ToString()[2].ToString()));
                else
                    lblRisultato.Text = AggiungiCentinaia(int.Parse(N.ToString()[0].ToString())) + AggiungiDecine(int.Parse(N.ToString()[1].ToString())) + AggiungiUnità(int.Parse(N.ToString()[2].ToString()));
                //
            }
            else
                lblRisultato.Text = "ATTENZIONE, NUMERO NON COMPRESO TRA (1,999)";
            
        }

        protected bool Compreso(int N, int Min, int Max)
        {
            if (N >= Min && N <= Max)
                return true;
            else
                return false;
        }

        protected string AggiungiUnità(int U)
        {
            return Unità[U];
        }

        protected string AggiungiDecine(int D)
        {
            return Decine[D];
        }

        protected string AggiungiCentinaia(int C)
        {
            if (C != 1)
                return Unità[C] + "cento";
            else
                return "cento";
        }
    }
}