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
            Wiek = DateTime.Now.Year - DataUrodzenia.Year;
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

        #endregion

        #region Do implementacji

        // Nie używane pola (dla testów)

        public string Login;
        public string Haslo;

        public string Zawod;
        public string Zamieszkanie;

        #endregion


    }
}
