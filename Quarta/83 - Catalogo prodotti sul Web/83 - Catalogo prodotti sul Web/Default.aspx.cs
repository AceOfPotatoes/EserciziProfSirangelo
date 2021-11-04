using System;
using System.IO;

namespace _83___Catalogo_prodotti_sul_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader FR = File.OpenText(Server.MapPath("Prodotti.txt"));
            while (!FR.EndOfStream)
            {
                string RigaLetta = FR.ReadLine();
                if(!Presente(RigaLetta))
                    ddlCategorie.Items.Add(RigaLetta);
                FR.ReadLine(); FR.ReadLine();
            }
            FR.Close();
        }

        protected bool Presente(string Riga)
        {
            for(int k=0; k<ddlCategorie.Items.Count; k++)
            {
                if (Riga == ddlCategorie.Items[k].ToString())
                    return true;
            }
            return false;
        }

        protected void plsVisualizza_Click(object sender, EventArgs e)
        {
            if(txtLimite.Text != "")
                Response.Redirect("/SecondaPagina.aspx?Categoria=" + ddlCategorie.Items[ddlCategorie.SelectedIndex].ToString() + "&Limite=" + txtLimite.Text);            
        }

        protected void lnkNuovoProdotto_Click(object sender, EventArgs e)
        {
            Response.Redirect("/NuovoProdotto.aspx?Categoria=" + ddlCategorie.Items[ddlCategorie.SelectedIndex].ToString());
        }
    }
}