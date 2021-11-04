using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Segnaposto_su_caselle
{
    class Dado
    {
        public Dado(){}

        public int LanciaDado()
        {
            Random R = new Random();
            return (R.Next(1, 6));            
        }
    }
}
