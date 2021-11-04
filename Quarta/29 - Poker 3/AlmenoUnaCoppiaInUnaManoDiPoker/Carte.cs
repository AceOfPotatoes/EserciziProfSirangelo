using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlmenoUnaCoppiaInUnaManoDiPoker
{
    class Carte
    {
        // attributi interni ...

        // i valori che codificano le carte possibili sono:
        // 1 (A), 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 (J), 12 (Q) e 13 (K)
        
        byte _Numero;

        // i valori che codificano i possibili pali sono:
        // 1 (Cuori), 2 (Quadri), 3 (Fiori), 4 (Picche)

        byte _Palo;

        
        // costruttori ...

        public Carte()
        {
            _Numero = 1;    // asso
            _Palo = 1;      // di cuori
        }

        public Carte(byte NumeroDellaCarta, byte PaloDellaCarta)
        {
            Numero = NumeroDellaCarta;
            Palo = PaloDellaCarta;
        }


        // eventi ...

        public event EventHandler NumeroDiCartaErrato;
        public event EventHandler PaloDellaCartaErrato;


        // proprietà ...

        public byte Numero
        {
            get { return _Numero; }
            set
            {
                if ((value < 1) || (value > 13))
                {
                    if (NumeroDiCartaErrato != null)
                        NumeroDiCartaErrato(this, new EventArgs());
                }
                else
                    _Numero = value;
            }
        }

        public byte Palo
        {
            get { return _Palo; }
            set
            {
                if ((value < 1) || (value > 4))
                {
                    if (PaloDellaCartaErrato != null)
                        PaloDellaCartaErrato(this, new EventArgs());
                }
                else
                    _Palo = value;
            }
        }


        // metodi ...

        public string ToString()
        {
            return ToStringNumero() + " di " + ToStringPalo();
        }

        public string ToStringNumero()
        {
            if (_Numero == 1)
                return "Asso";
            else if ((_Numero >= 2) && (_Numero <= 10))
                return _Numero.ToString();
            else if (_Numero == 11)
                return "J";
            else if (_Numero == 12)
                return "Q";
            else 
                return "K";
        }

        public string ToStringPalo()
        {
            if (_Palo == 1)
                return "Cuori";
            else if (_Palo == 2)
                return "Quadri";
            else if (_Palo == 3)
                return "Fiori";
            else
                return "Picche";
        }
    
        public bool UgualeA (Carte AltraCarta)
        {
            return ((_Numero == AltraCarta.Numero) &&
                      (_Palo == AltraCarta.Palo));
        }
    }
}
