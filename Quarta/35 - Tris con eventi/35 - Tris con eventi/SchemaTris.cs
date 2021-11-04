using System;
using System.Windows.Forms;


namespace _35___Tris_con_eventi
{
    class SchemaTris
    {
        private string Pallino;
        private string Crocetta;
        private char turno;
        public event EventHandler TrisCompletato;

        public char Turno
        {
            get { return turno; }
            set
            {
                if (value == 'X' || value == 'O')
                    turno = value;                
            }
        }

        public SchemaTris()
        {
            Pallino = "O";
            Crocetta = "X";
            Turno = 'X';
        }

        public void AssegnaCrocetta(Button Casella, Button A1, Button A2, Button A3, Button B1, Button B2, Button B3, Button C1, Button C2, Button C3, Label lblTurno)
        {
            Casella.Text = Crocetta;
            Casella.Enabled = false;

            if (ControlloTrisCompletato(A1, A2, A3, B1, B2, B3, C1, C2, C3))            
                TrisCompletato(this, new EventArgs());

            Turno = 'O';
            lblTurno.Text = Turno.ToString();
        }
        
        public void AssegnaPallino(Button Casella, Button A1, Button A2, Button A3, Button B1, Button B2, Button B3, Button C1, Button C2, Button C3, Label lblTurno)
        {
            Casella.Text = Pallino;
            Casella.Enabled = false;

            if (ControlloTrisCompletato(A1, A2, A3, B1, B2, B3, C1, C2, C3))
                TrisCompletato(this, new EventArgs());


            Turno = 'X';
            lblTurno.Text = Turno.ToString();
        }

        public bool ControlloTrisCompletato(Button A1, Button A2, Button A3, Button B1, Button B2, Button B3, Button C1, Button C2, Button C3)
        {
            return ((A1.Text == A2.Text && A3.Text == A2.Text && A1.Text != "" && A2.Text != "" && A3.Text != "") ||
                    (B1.Text == B2.Text && B3.Text == B2.Text && B1.Text != "" && B2.Text != "" && B3.Text != "") ||
                    (C1.Text == C2.Text && C3.Text == C2.Text && C1.Text != "" && C1.Text != "" && C1.Text != "") ||
                    (A1.Text == B1.Text && C1.Text == B1.Text && A1.Text != "" && B1.Text != "" && C1.Text != "") ||
                    (A2.Text == B2.Text && C2.Text == B2.Text && A2.Text != "" && B2.Text != "" && C2.Text != "") ||
                    (A3.Text == B3.Text && C3.Text == B3.Text && A3.Text != "" && B3.Text != "" && C3.Text != "") ||
                    (A1.Text == B2.Text && C3.Text == B2.Text && A1.Text != "" && B2.Text != "" && C3.Text != "") ||
                    (A3.Text == B2.Text && C1.Text == B2.Text && A3.Text != "" && B2.Text != "" && C1.Text != ""));
        }

    }
}
