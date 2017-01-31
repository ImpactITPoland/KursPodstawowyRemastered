using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPodstawowyRemastered.Klasy
{
    /// <summary>
    /// Testowa klasa
    /// </summary>
    public class TestowaKlasa
    {
        /// <summary>
        /// Testowy bazowy konstruktor klasy
        /// </summary>
        public TestowaKlasa()
        {

        }

        /// <summary>
        /// Testowy konstruktor z parameterem
        /// </summary>
        /// <param name="ilosc"></param>
        public TestowaKlasa(int ilosc)
        {
            Ilosc = ilosc;
        }

        /// <summary>
        /// Testowa zmienna
        /// </summary>
        public int Ilosc;

        /// <summary>
        /// Testowa metoda
        /// </summary>
        /// <param name="dodatek"></param>
        public void ZliczIlosc(int dodatek)
        {

        }
    }
}
