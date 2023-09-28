using System;

namespace Bank
{
    public class Konto
    {
        private double guthaben;
        private static int countKonto;
        private int kontoNr;

        public double Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public int KontoNr
        {
            get
            {
                return kontoNr;
            }
        }

        public Konto(double guthaben)
        {
            countKonto++;
            kontoNr = countKonto;

            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Eröffnungsbetrag darf nicht negativ sein.");
            }

            this.guthaben = guthaben;
        }

        public void Einzahlen(double betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(double betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}