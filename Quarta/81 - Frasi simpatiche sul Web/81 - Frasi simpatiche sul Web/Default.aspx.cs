using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _81___Frasi_simpatiche_sul_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                Visualizza();
        }

        protected void plsFiltra_Click(object sender, EventArgs e)
        {
            lstFrasi.Items.Clear();
            string Filtro = txtFiltro.Text;
            StreamReader FR = File.OpenText(Server.MapPath("ElencoFrasi.txt"));

            while (!FR.EndOfStream)
            {
                string RigaLetta = FR.ReadLine();
                if (RigaLetta.IndexOf(Filtro) != -1)
                    lstFrasi.Items.Add(RigaLetta);
            }

            FR.Close();
        }

        protected void plsElimina_Click(object sender, EventArgs e)
        {
            StreamReader FR = File.OpenText(Server.MapPath("ElencoFrasi.txt"));
            int Indice = lstFrasi.SelectedIndex;
            string Rimuovi = lstFrasi.Items[Indice].ToString();
            List<string> Elenco = new List<string>();

            while (!FR.EndOfStream)
            {
                string RigaLetta = FR.ReadLine();
                if (RigaLetta != Rimuovi)
                    Elenco.Add(RigaLetta);
            }

            FR.Close();

            StreamWriter FW = File.CreateText(Server.MapPath("ElencoFrasi.txt"));

            for (int k = 0; k < Elenco.Count; k++)
                FW.WriteLine(Elenco[k]);

            FW.Close();

            Visualizza();
        }

        private void Visualizza()
        {
            StreamReader FR = File.OpenText(Server.MapPath("ElencoFrasi.txt"));
            lstFrasi.Items.Clear();

            while (!FR.EndOfStream)
                lstFrasi.Items.Add(FR.ReadLine());

            FR.Close();
        }

        protected void plsAggiungi_Click(object sender, EventArgs e)
        {
            string NuovaFrase = txtFrase.Text;

            StreamWriter FW = File.AppendText(Server.MapPath("ElencoFrasi.txt"));
            FW.WriteLine(NuovaFrase);
            FW.Close();

            Visualizza();
        }
    }
}