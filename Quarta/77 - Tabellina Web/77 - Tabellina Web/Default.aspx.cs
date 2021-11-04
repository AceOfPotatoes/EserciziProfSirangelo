using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _77___Tabellina_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessaggio.Visible = true;
                lblMessaggio.Text = "BENVENUTO IN TABELLINA WEB, INSERISCI UN NUMERO COMPRESO FRA (1,9) PER VEDERE VISUALIZZATA LA SUA SUCCESSIONE!!";
            }
            else
                lblMessaggio.Visible = false;
        }

        protected void plsMostra_Click(object sender, EventArgs e)
        {
            lblTabellina.Text = "";

            if (int.Parse(txtN.Text) > 0 && int.Parse(txtN.Text) < 10)
            {
                int N = int.Parse(txtN.Text);

                for(int k = 1; k<=10; k++)
                {
                    if (k == 10)
                        lblTabellina.Text += N * k + " ";
                    else
                        lblTabellina.Text += N * k + " - ";
                }
            }
            else
                lblTabellina.Text = "NUMERO NON COMPRESO FRA (1,9)!!!";
            
        }
    }
}