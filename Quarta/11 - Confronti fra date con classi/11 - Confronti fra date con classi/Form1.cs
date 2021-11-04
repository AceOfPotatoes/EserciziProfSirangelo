using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11___Confronti_fra_date_con_classi
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        MiaData D1;
        MiaData D2;

        private void plsRecente_Click(object sender, EventArgs e)
        {
            int NuovoGiorno1 = Convert.ToInt32(numG.Value);
            int NuovoMese1 = Convert.ToInt32(numM.Value);
            int NuovoAnno1 = Convert.ToInt32(numA.Value);
            int NuovoGiorno2 = Convert.ToInt32(numG2.Value);
            int NuovoMese2 = Convert.ToInt32(numM2.Value);
            int NuovoAnno2 = Convert.ToInt32(numA2.Value);

            D1 = new MiaData(NuovoGiorno1, NuovoMese1, NuovoAnno1);
            D2 = new MiaData(NuovoGiorno2, NuovoMese2, NuovoAnno2);

            if (D1.PiùRecente(D2))
                MessageBox.Show("La data più recente è la D1");
            else
                MessageBox.Show("La data più recente è la D2");
        }

        private void plsNatale_Click(object sender, EventArgs e)
        {
            int NuovoGiorno1 = Convert.ToInt32(numG.Value);
            int NuovoMese1 = Convert.ToInt32(numM.Value);
            int NuovoAnno1 = Convert.ToInt32(numA.Value);
            int NuovoGiorno2 = Convert.ToInt32(numG2.Value);
            int NuovoMese2 = Convert.ToInt32(numM2.Value);
            int NuovoAnno2 = Convert.ToInt32(numA2.Value);

            D1 = new MiaData(NuovoGiorno1, NuovoMese1, NuovoAnno1);
            D2 = new MiaData(NuovoGiorno2, NuovoMese2, NuovoAnno2);

            int GiorniPerNatale = D1.GiorniPerNatale();
            MessageBox.Show("Per il prossimo Natale da D1 mancano " + GiorniPerNatale + " giorni", "RISULTATO CALCOLO");
        }

        private void plsGiorni_Click(object sender, EventArgs e)
        {
            int NuovoGiorno1 = Convert.ToInt32(numG.Value);
            int NuovoMese1 = Convert.ToInt32(numM.Value);
            int NuovoAnno1 = Convert.ToInt32(numA.Value);
            int NuovoGiorno2 = Convert.ToInt32(numG2.Value);
            int NuovoMese2 = Convert.ToInt32(numM2.Value);
            int NuovoAnno2 = Convert.ToInt32(numA2.Value);

            D1 = new MiaData(NuovoGiorno1, NuovoMese1, NuovoAnno1);
            D2 = new MiaData(NuovoGiorno2, NuovoMese2, NuovoAnno2);

            MessageBox.Show("Fra le date ci sono " + D1.GiorniFraLeDate(D2) + " giorni", "RISULTATO");
        }
    }
}
