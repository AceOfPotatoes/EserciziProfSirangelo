using System;
using System.IO;

namespace _83___Catalogo_prodotti_sul_Web
{
    public partial class NuovoProdotto : System.Web.UI.Page
    {
        string Categoria = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Categoria = Request.QueryString["Categoria"];
            lblCategoria.Text = Categoria;
        }

        protected void plsAggiungi_Click(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;
            if (Password == "fettabiscottata")
            {
                string Prezzo = txtPrezzo.Text;
                string Prodotto = txtProdotto.Text;

                StreamWriter FW = File.AppendText(Server.MapPath("Prodotti.txt"));
                FW.WriteLine(Categoria);
                FW.WriteLine(Prodotto);
                FW.WriteLine(Prezzo);
                FW.Close();

                lblEsito.Text = "PRODOTTO AGGIUNTO";
            }
            else
                lblEsito.Text = "PASSWORD ERRATA, RIPROVA";                        
        }

        protected void lnkHomepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}