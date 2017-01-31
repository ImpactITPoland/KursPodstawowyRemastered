using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPodstawowyRemastered.Klasy
{
    /// <summary>
    /// Klasa do wykonywania obliczeń programu
    /// </summary>
    public class Licznik
    {


        /// <summary>
        /// Dodaje dwie liczby calkowite
        /// </summary>
        /// <param name="pierwsza">Pierwsza liczba</param>
        /// <param name="druga">Druga liczba</param>
        /// <returns></returns>
        public int DodajDwieLiczbyCalkowite(int pierwsza, int druga)
        {
            // Zabezpieczenie: kiedy ktos przekazal pusta wartość
            if (pierwsza == null || druga == null)
                return 0;

            return pierwsza + druga;
        }
    }
}
