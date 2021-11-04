using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___Differenza_date_con_multiform
{
    public class Data
    {
        public int Giorno = 1;
        public int Mese = 1;
        public int Anno = 2000;

        public Data() { }

        public int GiorniCheIntercorronoDa(Data O2)
        {
            return Math.Abs(DaPrimoDuemilaAChiamante() - O2.DaPrimoDuemilaAChiamante());
        }

        private int DaPrimoDuemilaAChiamante()
        {
            return (Anno - 2000) * 360 - (360 - ((Mese - 1) * 30 + Giorno));
        }

        public override string ToString()
        {
            return Convert.ToString(Giorno) + "-" + Convert.ToString(Mese) + "-" + Convert.ToString(Anno);
        }
    }    
}
