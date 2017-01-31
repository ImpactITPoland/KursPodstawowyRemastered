using KursPodstawowyRemastered.Helpers;
using System;


namespace KursPodstawowyRemastered.Klasy
{
    /// <summary>
    /// Klasa Człowiek
    /// </summary>
    public class Czlowiek
    {
        #region Konstruktory

        /// <summary>
        /// Konstruktor klasy Człowiek
        /// </summary>
        /// <param name="imie">Imię ludzia</param>
        /// <param name="rasa">Rasa ludzia (enum)</param>
        /// <param name="dataUrodzenia">Data urodzenia ludzia</param>
        public Czlowiek(string imie, Rasy rasa, DateTime dataUrodzenia)
        {
            Imie = imie;
            Rasa = rasa;
            DataUrodzenia = dataUrodzenia;
            Wiek = Licznik.ObliczRozniceDat(DataUrodzenia);
            Haslo = "";
            Login = "NO LOGIN HERE";
        }


        /// <summary>
        /// Konstruktor klasy Człowiek
        /// </summary>
        /// <param name="imie"></param>
        /// <param name="rasa"></param>
        /// <param name="dataUrodzenia"></param>
        /// <param name="haslo"></param>
        public Czlowiek(string imie, Rasy rasa, DateTime dataUrodzenia, string haslo, string login)
        {
            Imie = imie;
            Rasa = rasa;
            DataUrodzenia = dataUrodzenia;
            Wiek = Licznik.ObliczRozniceDat(DataUrodzenia);
            Haslo = haslo;
            Login = SprawdzLogin(login) ? login : "Bad login";
        }

        #endregion

        #region Własności

        /// <summary>
        /// Imię
        /// </summary>
        public string Imie { get; set; }
        /// <summary>
        /// Rasa
        /// </summary>
        public Rasy Rasa { get; set; }
        /// <summary>
        /// Datat urodzenia (format yyyy-mm-dd)
        /// </summary>
        public DateTime DataUrodzenia { get; set; }
        /// <summary>
        /// Wiek (obliczany automatycznie)
        /// </summary>
        public int Wiek { get; }

        public string Login { get; set; }
        public string Haslo { get; set; }
        #endregion

        #region Do implementacji

        // Nie używane pola (dla testów)

        public string Zawod;
        public string Zamieszkanie;

        #endregion

        #region Metody
        /// <summary>
        /// Generuj hasło z GUID
        /// </summary>
        /// <returns></returns>
        public string GenerujHaslo()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Tajemnicze sprawdzanie loginu
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private bool SprawdzLogin(string login)
        {
            bool isCorrected = false;

            if (login.Length > 7)
                isCorrected = true;

            return isCorrected;
        }
        #endregion

    }
}
