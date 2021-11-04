using System;
using System.Windows.Forms;

namespace _35___Tris_con_eventi
{
    public partial class frmTris : Form
    {
        public frmTris()
        {
            InitializeComponent();
        }

        SchemaTris mioSchema;
        // mioSchema.AssegnaCrocetta(Casella, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3);

        private void frmTris_Load(object sender, EventArgs e)
        {
            mioSchema = new SchemaTris();
            mioSchema.TrisCompletato += GestisciTrisCompletato;
            lblTurno.Text = mioSchema.Turno.ToString();
        }

        private void GestisciTrisCompletato(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                MessageBox.Show("Crocetta ha vinto!!!", "COMPLIMENTI");
            else
                MessageBox.Show("Pallina ha vinto!!!", "COMPLIMENTI");
            Application.Exit();
        }

        private void plsA1_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsA1, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsA1, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void plsA2_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsA2, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsA2, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void plsA3_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsA3, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsA3, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void plsB1_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsB1, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsB1, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void plsB2_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsB2, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsB2, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void plsB3_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsB3, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsB3, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void plsC1_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsC1, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsC1, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void plsC2_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsC2, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsC2, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void plsC3_Click(object sender, EventArgs e)
        {
            if (mioSchema.Turno == 'X')
                mioSchema.AssegnaCrocetta(plsC3, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);
            else
                mioSchema.AssegnaPallino(plsC3, plsA1, plsA2, plsA3, plsB1, plsB2, plsB3, plsC1, plsC2, plsC3, lblTurno);

            TogliFuoco();
        }

        private void TogliFuoco()
        {
            plsTogliFuoco.Focus();
        }
    }
}
