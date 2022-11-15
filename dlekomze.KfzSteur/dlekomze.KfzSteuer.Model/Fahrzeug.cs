namespace dlekomze.KfzSteuer.Model
{
    public abstract class Fahrzeug
    {
        public string Kennzeichen { get; set; }
        public DateTime Erstzulassung { get; set; }
        public int Hubraum { get; set; }
        public int Leistung { get; set; }

        public Fahrzeug(string kennzeichen, DateTime erstzulassung, int hubraum, int leistung)
        {
            Kennzeichen = kennzeichen;
            Erstzulassung = erstzulassung;
            Hubraum = hubraum;
            Leistung = leistung;
        }

        public abstract decimal BerechneSteuer();

        public int NaechsteHauptuntersuchung()
        {
            int yeardiff = DateTime.Now.Year - Erstzulassung.Year - 3;

            while(yeardiff > 0)
            {
                yeardiff -= 2;
            }

            return DateTime.Now.Year - yeardiff;
        }
    }
}