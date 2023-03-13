using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta
{
    public class Soldi
    {
        private double _importo;
        private string _valuta;
        private static string[] valute = new string[] { "USD", "GBP", "EUR", "CHF", "CAD", "AUD", "NZD" };
        private static List<string> _valuteAccettate = new List<string>(valute);

        public Soldi(double importo, string valuta)
        {
            Importo = importo;
            Valuta = valuta;
        }

        /*properties*/
        public double Importo
        {
            get
            {
                return _importo;
            }
            set
            {
                if (value > 0)
                {
                    _importo = value;
                }
                else
                {
                    throw new Exception("Il campo \"Importo\" deve essere maggiore di 0");
                }
            }
        }
        public string Valuta
        {
            get
            {
                return _valuta;
            }
            set
            {
                //string[] valuteAccettate = new string[] { "EURO", "DOLLARI", "STERLINE" };
                InserisciSeStringaValida(ref _valuta, value, "Valuta");
            }
        }
        public static string[] ValuteAccettate
        {
            get
            {
                return _valuteAccettate.ToArray();
            }
        }
        /*fine properties*/

        public static double CambiaValuta(string valutaIniziale, string valutaFinale, double importo)
        {
            //USD, GBP, EUR, CHF, CAD, AUD, NZD
            double[] cambioInEuro = new double[] { 0.94, 1.13, 1, 1.02, 0.68, 0.62, 0.58 };
            double[] cambioDaEuro = new double[] { 1.06, 0.88, 1, 0.98, 1.47, 1.62, 1.73 };

            if (!ValuteAccettate.Contains(valutaIniziale) || !ValuteAccettate.Contains(valutaFinale))
            {
                throw new Exception("Inserire valute accettabili");
            }
            else if (importo < 0)
            {
                throw new Exception("Inserire un importo valido");
            }

            double tmp = importo * cambioInEuro[_valuteAccettate.IndexOf(valutaIniziale)]; /*prima converto in euro per comodità*/
            tmp *= cambioDaEuro[_valuteAccettate.IndexOf(valutaFinale)]; /*poi da euro a quello che serve*/

            return tmp;
        }

        protected void InserisciSeStringaValida(ref string campo, string val, string perErrore)
        {
            if (!String.IsNullOrWhiteSpace(val))
            {
                campo = val;
            }
            else
            {
                throw new Exception($"Inserire il campo \"{perErrore}\" valido");
            }
        }
    }
}
