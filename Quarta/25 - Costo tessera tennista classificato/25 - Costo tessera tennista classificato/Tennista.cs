using System.Windows.Forms;

namespace _25___Costo_tessera_tennista_classificato
{
    class Tennista
    {
        public string Nominativo;

        //false: mancino \ true: destro
        public bool PreferenzaManuale;

        public Regione miaRegione = new Regione();
                        
        public Tennista(string NuovoNominativo, bool NuovaPreferenzaManuale, string NuovaRegione)
        {
            Nominativo = NuovoNominativo;
            PreferenzaManuale = NuovaPreferenzaManuale;
            miaRegione.NomeRegione = NuovaRegione;
        }

        public virtual void VisualizzaDatiTennista(Label lblNome, Label lblRegione, Label lblPrefMan, Label lblCat, Label lblIscr)
        {
            lblNome.Text = Nominativo;
            if (PreferenzaManuale)
                lblPrefMan.Text = "D";
            else
                lblPrefMan.Text = "S";
            lblRegione.Text = miaRegione.NomeRegione;
        }

        public virtual void CalcolaEVisualizzaContributo(Label lblContributo)
        {
            lblContributo.Text = "50€";
        }


    }
}
