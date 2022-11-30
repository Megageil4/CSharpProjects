using ArbeitenMitDelegates.Model;

namespace ArbeitenMitDelegates.DataAccess
{
	public class FahrzeugRepository
	{

    public List<Fahrzeug> AlleFahrzeuge { get; }

    public FahrzeugRepository()
    {
      // Liste instanziieren und vorbelegen
      AlleFahrzeuge = new List<Fahrzeug>()
      {
        new Fahrzeug(){Kennzeichen="DEG AB 123", Erstzulassung = new DateTime(2010,5,17), Hersteller = "BMW", Kilometerstand=77348},
        new Fahrzeug(){Kennzeichen="DEG CD 456", Erstzulassung = new DateTime(2015,7,29), Hersteller = "Audi", Kilometerstand=52963},
        new Fahrzeug(){Kennzeichen="PA UL 42", Erstzulassung = new DateTime(2013,9,14), Hersteller = "Mercedes", Kilometerstand=32762},
        new Fahrzeug(){Kennzeichen="R EX 99", Erstzulassung = new DateTime(2017,6,22), Hersteller = "BMW", Kilometerstand=15386},
        new Fahrzeug(){Kennzeichen="PA X 777", Erstzulassung = new DateTime(2016,7,9), Hersteller = "BMW", Kilometerstand=27491},
        new Fahrzeug(){Kennzeichen="DEG TV 9613", Erstzulassung = new DateTime(2017,8,25), Hersteller = "Audi", Kilometerstand=6347}
      };
    }

        public IEnumerable<Fahrzeug> FahrzeugeVonBMW()
		{
			foreach (var fahrzeug in AlleFahrzeuge)
			{
				if (fahrzeug.Hersteller == "BMW")
				{
                    yield return fahrzeug;
				}
			}
		}

		public IEnumerable<Fahrzeug> FahrzeugeVonAudi()
		{
			foreach (var fahrzeug in AlleFahrzeuge)
			{
				if (fahrzeug.Hersteller == "Audi")
				{
					yield return fahrzeug;
				}
			}
		}

		public IEnumerable<Fahrzeug> FahrzeugeVonHersteller(string hersteller)
		{
			foreach (var fahrzeug in AlleFahrzeuge)
			{
				if (fahrzeug.Hersteller == hersteller)
				{
					yield return fahrzeug;
				}
			}
		}

		public IEnumerable<Fahrzeug> FahrzeugeMitMaxKilometer(int kilometerstand)
		{
			foreach (var fahrzeug in AlleFahrzeuge)
			{
				if (fahrzeug.Kilometerstand <= kilometerstand)
				{
					yield return fahrzeug;
				}
			}
		}

		public IEnumerable<Fahrzeug> Filtern(Func<Fahrzeug, bool> pruefenFahrzeug)
		{
			foreach (var fahrzeug in AlleFahrzeuge)
			{
				if (pruefenFahrzeug(fahrzeug))
				{
					yield return fahrzeug;
				}
			}
		}
	}
}