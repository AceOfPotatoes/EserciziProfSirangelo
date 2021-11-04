using System;
using System.Collections.Generic;   // necessario per usare la classe List
using System.Windows.Forms;


namespace AlmenoUnaCoppiaInUnaManoDiPoker
{
    class Mazzi
    {
        // attributi interni ...

        // List è come un ArrayList ... non è altro che una Collection ...
        // List<Carte> significa che la collection conterrà oggetti di classe Carte

        private List<Carte> _Mazzo;


        // costruttori ...

        public Mazzi()
        {
            _Mazzo = new List<Carte>();
        }

        public Mazzi(byte TipoDiMazzo)
        {
            if (TipoDiMazzo == 52)
            {
                _Mazzo = new List<Carte>();

                for (byte Kp = 1; Kp <= 4; Kp++)
                    for (byte Kn = 1; Kn <= 13; Kn++)
                    {
                        Carte NuovaCarta = new Carte(Kn, Kp);
                        Aggiungi(NuovaCarta);

                        // ... si poteva fare direttamente: Aggiungi(new Carte(Kn, Kp))
                    }
            }
        }


        // eventi ...

        public event EventHandler CartaGiaPresenteNelMazzo;


        // metodi ...

        public bool Esiste(Carte CartaDaVerificare)
        {
            bool Esito = false;
            
            // scorri tutte le carte del mazzo ...
            for (byte K = 0; K <= _Mazzo.Count - 1; K++)

                // se la carta in posizione K è uguale a quella da verificare ...
                if (CartaDaVerificare.UgualeA(_Mazzo[K]))
                {
                    Esito = true;
                    break;
                }

            return Esito;
        }

        public void Aggiungi(Carte NuovaCarta)
        {
            _Mazzo.Add(NuovaCarta);
        }

        public Carte EstraiCartaInPosizione(byte Posizione)
        {
            Carte CartaEstratta;
            if (Posizione < _Mazzo.Count && Posizione >= 0)
            {
                CartaEstratta = _Mazzo[Posizione];
                _Mazzo.RemoveAt(Posizione);
                return CartaEstratta;
            }                
      

            return null;
        }

        public Carte EstraiPrimaCarta()
        {
            Carte CartaEstratta = _Mazzo[0];
            _Mazzo.RemoveAt(0);
            return CartaEstratta;
        }

        public void Mischia()
        {
            Mazzi MazzoMischiato = new Mazzi();
            Random R = new Random();
            byte PosizioneCarta = 0;

            // crea un nuovo mazzo estraendo casualmente 
            // le carte dal mazzo dell'oggetto ...

            for (int K = 51; K >= 0; K--)  // K deve essere int perchè alla fine vale -1!
            {
                PosizioneCarta = (byte)R.Next(K + 1);
                MazzoMischiato.Aggiungi(EstraiCartaInPosizione(PosizioneCarta));
            }

            // azzera il mazzo dell'oggetto e copia le carte
            // "mischiate" dal nuovo mazzo al mazzo dell'oggetto ...

            _Mazzo = new List<Carte>();
            for (byte K = 0; K <= 51; K++)
                Aggiungi(MazzoMischiato.EstraiPrimaCarta());
        }

        public void VisualizzaInListBox(ListBox L)
        {
            L.Items.Clear();
            for (byte K = 0; K <= _Mazzo.Count - 1; K++)
                L.Items.Add(_Mazzo[K].ToString());
        }

        public bool èCoppia()
        {
            bool Esito = false;

            for (int K1 = 0; K1 <= _Mazzo.Count - 2; K1++)
                for (int K2 = K1 + 1; K2 <= _Mazzo.Count - 1; K2++)
                    if (_Mazzo[K1].Numero == _Mazzo[K2].Numero)
                        Esito = true;

            return Esito;
        }

        public bool èTris()
        {
            int CarteUguali = 0;
            for (int K1 = 0; K1 <= _Mazzo.Count - 2; K1++)
            {
                Carte CartaDaConfrontare = _Mazzo[K1];
                for (int K2 = K1 + 1; K2 < _Mazzo.Count; K2++)
                {
                    if (_Mazzo[K2].Numero == CartaDaConfrontare.Numero)
                        CarteUguali++;
                }
                if (CarteUguali == 3)
                    return true;
            }

            return false;
        }

        public bool èPoker()
        {
                int CarteUguali = 0;
                for (int K1 = 0; K1 <= _Mazzo.Count - 2; K1++)
                {
                    Carte CartaDaConfrontare = _Mazzo[K1];
                    for (int K2 = K1 + 1; K2 < _Mazzo.Count; K2++)
                    {
                        if (_Mazzo[K2].Numero == CartaDaConfrontare.Numero)
                            CarteUguali++;
                    }
                    if (CarteUguali == 4)
                        return true;
                }
                return false;

        }

        public bool èColore()
        {
            int PaliUguali = 0;

            Carte CartaDaConfrontare = _Mazzo[0];
            for (int K = 0; K < _Mazzo.Count; K++)
                if (_Mazzo[K].Palo == CartaDaConfrontare.Palo)
                    PaliUguali++;

                if (PaliUguali == 5)
                    return true;

            return false;
        }
            
        

        public bool èScala()
        {
            int SuccessiviAPrecedente = 1;
            Carte CartaDaConfrontare = _Mazzo[0];
            for (int K = 1; K < _Mazzo.Count; K++)
                if (_Mazzo[K].Numero == CartaDaConfrontare.Numero+1)
                SuccessiviAPrecedente++;

            if (SuccessiviAPrecedente == 5)
                return true;

            return false;
        }

        public bool èFull()
        {
            bool Coppia = false;
            bool Tris = false;
            int CarteUguali = 1;
            int RiprendiDa = 0;

            for (int K1 = 0; K1 <= _Mazzo.Count - 2; K1++)
            {
                Carte CartaDaConfrontare = _Mazzo[K1];
                for (int K2 = K1 + 1; K2 < _Mazzo.Count; K2++)
                {
                    if (_Mazzo[K2].Numero == CartaDaConfrontare.Numero)
                        CarteUguali++;
                }
                if (CarteUguali == 3)
                {
                    Tris = true;
                    RiprendiDa = K1 + 1;
                    CarteUguali = 1;
                }                           
            }

            for (int K1 = RiprendiDa; K1 <= _Mazzo.Count - 2; K1++)
            {
                Carte CartaDaConfrontare = _Mazzo[K1];

                for (int K2 = K1 + 1; K2 < _Mazzo.Count; K2++)
                {
                    if (_Mazzo[K2].Numero == CartaDaConfrontare.Numero)
                        CarteUguali++;
                }
                if (CarteUguali == 2)
                    Coppia = true;
            }

            
            return Coppia && Tris;
        }

        public bool èScalaReale()
        {
            int SuccessiviAPrecedente = 1;
            for (int K1 = 0; K1 <= _Mazzo.Count - 2; K1++)
            {
                Carte CartaDaConfrontare = _Mazzo[K1];
                for (int K2 = K1 + 1; K2 < _Mazzo.Count; K2++)
                {
                    if (_Mazzo[K2].Numero == CartaDaConfrontare.Numero + 1 && _Mazzo[K2].Palo == CartaDaConfrontare.Palo)
                        SuccessiviAPrecedente++;
                }
                if (SuccessiviAPrecedente == 5)
                    return true;
            }

            return false;
        }

        public int NumeroCarteNellaMano()
        {
            return _Mazzo.Count;
        }

        public bool PossibileDareCarte()
        {
            if (_Mazzo.Count >= 5)
                return true;
            else
                return false;
        }

        public void Ordina()
        {           
            for (int K1 = 0; K1 <= _Mazzo.Count - 2; K1++)
            {
                int PosMin = K1;
                for (int K2 = K1 + 1; K2 < _Mazzo.Count; K2++)
                    if (_Mazzo[K2].Numero < _Mazzo[PosMin].Numero)
                        PosMin = K2;

                Carte Temp = _Mazzo[K1];
                _Mazzo[K1] = _Mazzo[PosMin];
                _Mazzo[PosMin] = Temp;
            }
        }
    }
}
