using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _82___Dati_studenti_sul_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void plsInvia_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SecondaPagina.aspx?Classe=" + txtClasse.Text);
        }
    }
}