using System;

namespace _76___Calcolatrice_Web
{
    public partial class Default : System.Web.UI.Page
    {
        double A;
        double B;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessaggio.Visible = true;
                lblMessaggio.Text = "Benvenuto nella calcolatrice online!!!";
            }
            else
                lblMessaggio.Visible = false;
        }

        protected void plsSomma_Click(object sender, EventArgs e)
        {
            CaricaValori();
            lblRisultato.Text = (A + B).ToString();
        }

        protected void plsSottrazione_Click(object sender, EventArgs e)
        {
            CaricaValori();
            lblRisultato.Text = (A - B).ToString();
        }

        protected void plsMoltiplicazione_Click(object sender, EventArgs e)
        {
            CaricaValori();
            lblRisultato.Text = Math.Round(A * B, 2).ToString();
        }

        protected void plsDivisione_Click(object sender, EventArgs e)
        {
            CaricaValori();
            lblRisultato.Text = Math.Round(A / B, 2).ToString();
        }

        protected void plsPotenza_Click(object sender, EventArgs e)
        {
            CaricaValori();
            lblRisultato.Text = Math.Pow(A, B).ToString();
        }

        protected void CaricaValori()
        {
            A = Convert.ToDouble(txtA.Text);
            B = Convert.ToDouble(txtB.Text);
        }

        protected void plsReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lblRisultato.Text = "";
        }
    }
}