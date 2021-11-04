using System;
using System.IO;

namespace _83___Catalogo_prodotti_sul_Web
{
    public partial class SecondaPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Categoria = Request.QueryString["Categoria"];
            float Limite = Convert.ToSingle(Request.QueryString["Limite"]);

            lblCategoria.Text = Categoria;

            StreamReader FR = File.OpenText(Server.MapPath("Prodotti.txt"));

            while (!FR.EndOfStream)
            {
                string RigaLetta = FR.ReadLine();
                string Prodotto = FR.ReadLine();
                float Prezzo = Convert.ToSingle(FR.ReadLine());
                if(RigaLetta == Categoria)
                    if (Prezzo <= Limite)
                        lstProdotti.Items.Add(Prodotto + " - " + Prezzo + "€");
            }

            FR.Close();
        }

        protected void lnkHomepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}