using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Eventi_orario
{
    class Orario
    {
        public Orario()
        {
            Ora = 0;
            Minuti = 0;
        }


        private int ora;
        private int minuti;
        public event EventHandler OraErrata;
        public event EventHandler MinutiErrati;

        public int Ora
        {
            get { return ora; }
            set
            {
                if (value >= 0 && value < 24)
                    ora = value;
                else
                    OraErrata(this, new EventArgs());                    
            }
        }

        public int Minuti
        {
            get { return minuti; }
            set
            {
                if (value >= 0 && value < 60)
                    minuti = value;
                else
                    MinutiErrati(this, new EventArgs());                  
            }
        }

        public int MinutiAMezzanotte()
        {
            return (23 - ora) * 60 + (60 - minuti);
        }
    }
}
