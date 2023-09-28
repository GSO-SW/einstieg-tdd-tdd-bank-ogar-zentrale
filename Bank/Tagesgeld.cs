using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Tagesgeld
    {
        private double guthaben;
        private int verrechnungsKontoNr;
        private double zinssatz;
        private Konto konto;

        public double Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public double Zinssatz
        {
            get
            {
                return zinssatz;
            }

            set { zinssatz = value; }
        }

        public int VerrechnungsKontoNr
        {
            get
            {
                return verrechnungsKontoNr;
            }
        }

        public Tagesgeld(Konto konto)
        {
            this.konto = konto;
            this.guthaben = konto.Guthaben;
            this.guthaben = 0.0;
            this.verrechnungsKontoNr = konto.KontoNr;
        }

        public void Einzahlen(double betrag)
        {
            konto.Auszahlen(betrag);
            guthaben += betrag;
        }

        public void Auszahlen(double betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
                konto.Einzahlen(betrag);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
