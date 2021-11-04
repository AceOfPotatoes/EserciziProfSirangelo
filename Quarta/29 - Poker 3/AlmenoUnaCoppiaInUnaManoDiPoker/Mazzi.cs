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
            if (Esiste(NuovaCarta))
            {
                if (CartaGiaPresenteNelMazzo != null)
                    CartaGiaPresenteNelMazzo(this, new EventArgs());
            }
            else
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

        public bool e_Coppia()
        {
            bool Esito = false;

            for (int K1 = 0; K1 <= _Mazzo.Count - 2; K1++)
                for (int K2 = K1 + 1; K2 <= _Mazzo.Count - 1; K2++)
                    if (_Mazzo[K1].Numero == _Mazzo[K2].Numero)
                        Esito = true;

            return Esito;
        }

        public bool PossibileDareCarte()
        {
            if (_Mazzo.Count >= 5)
                return true;
            else
                return false;
        }

        public Carte CartaAltaMazzo()
        {
            Carte CartaAlta = _Mazzo[0];

                for (int K = 1; K <= _Mazzo.Count - 1; K++)
                {
                    if (CartaAlta.Numero != 1 && _Mazzo[K].Numero != 1)
                        if (CartaAlta.Numero < _Mazzo[K].Numero)
                            CartaAlta = _Mazzo[K];

                    if (CartaAlta.Numero != 1 && _Mazzo[K].Numero == 1)
                        CartaAlta = _Mazzo[K];

                    if (CartaAlta.Numero == _Mazzo[K].Numero)
                        if (CartaAlta.Palo > _Mazzo[K].Palo)
                            CartaAlta = _Mazzo[K];
                    
                }
                   


            return CartaAlta;
        }
    }
}
