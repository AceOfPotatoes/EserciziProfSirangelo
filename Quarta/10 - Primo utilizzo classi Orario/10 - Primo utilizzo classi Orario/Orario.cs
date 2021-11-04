namespace _10___Primo_utilizzo_classi_Orario
{
    class Orario
    {
        private int Ora;
        private int Min;

        public Orario()
        {
            Ora = 0;
            Min = 0;
        }

        public Orario(int NuovaOra, int NuovoMin)
        {
            Ora = NuovaOra;
            Min = NuovoMin;
        }

        public bool AntiMeridiano()
        {
            return (Ora < 12);
        }

        public int MinutiDaScorsaMezzanotte()
        {
            return ((Ora * 60) + Min);
        }

        public bool PrecedenteA(Orario O2)
        {
            return (Ora < O2.Ora || Ora == O2.Ora && Min < O2.Min);
        }
    }
}
