using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Confronti_fra_date_con_classi
{
    class MiaData
    {
        private int Giorno;
        private int Mese;
        private int Anno;
        
        public MiaData()
        {
            Giorno = 1;
            Mese = 1;
            Anno = 2000;
        }

        public MiaData(int NuovoGiorno, int NuovoMese, int NuovoAnno)
        {
            Giorno = NuovoGiorno;
            Mese = NuovoMese;
            Anno = NuovoAnno;
        }

        public bool PiùRecente(MiaData D2)
        {
            return (Anno < D2.Anno || Anno == D2.Anno && Mese < D2.Mese || Anno == D2.Anno && Mese == D2.Mese && Giorno < D2.Giorno);
        }

        public int GiorniPerNatale()
        {
            return ((11 - Mese) * 30 + (30 + (25 - Giorno)));
        }

        public int GiorniFraLeDate(MiaData D2)
        {
            return ((Math.Abs(Anno - D2.Anno) * 360) + (Math.Abs(Mese - D2.Mese) * 30) + Math.Abs(Giorno - D2.Giorno));
        }
    }
}
