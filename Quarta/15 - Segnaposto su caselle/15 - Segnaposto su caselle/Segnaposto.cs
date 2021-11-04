using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Segnaposto_su_caselle
{
    class Segnaposto
    {
        private int _Pos;
        private int _CasOcc;

        public int Posizione
        {
            get { return _Pos; }
            set { _Pos = value; }
        }

        public int CasellaOccupata
        {
            get { return _CasOcc; }
            set { _CasOcc = value; }
        }

        public Segnaposto()
        {
            CasellaOccupata = 0;
        }      
        
        public void AssegnaPosizione(Segnaposto G2)
        {
            if (CasellaOccupata > G2.CasellaOccupata)
            {
                Posizione = 1;
                G2.Posizione = 2;
            }
            else
            {
                Posizione = 2;
                G2.Posizione = 1;
            }            
        }

        public void AvanzaDi(int PassiAvanti)
        {
            CasellaOccupata += PassiAvanti;
        }

        public void Arretra(int PassiIndietro)
        {
            if (CasellaOccupata+1 > PassiIndietro)
                CasellaOccupata -= PassiIndietro;
            else
                CasellaOccupata = 0;
        }    
        


    }
}
