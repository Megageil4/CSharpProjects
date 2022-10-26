using Notenverwaltung.Model;

namespace Notenverwaltung.DataAccess
{
	public class FakeZensurenRepository : IZensurenRepository
	{
		#region Fields
		readonly List<Zensur> _zensuren;
		#endregion

		#region Constructors
		public FakeZensurenRepository()
		{
			_zensuren = new List<Zensur>()
			{
			 new Zensur("Prog", new DateTime(2017, 6, 24), 2, Leistungsart.KA),
			 new Zensur("Prog", new DateTime(2017, 5, 21), 3, Leistungsart.SA),
			 new Zensur("Prog", new DateTime(2017, 5, 5), 3, Leistungsart.KA),
			 new Zensur("Prog", new DateTime(2017, 4, 17), 2, Leistungsart.mdl),
			 new Zensur("Prog", new DateTime(2017, 2, 20), 2, Leistungsart.SA),
			 new Zensur("Prog", new DateTime(2016, 10, 25), 5, Leistungsart.mdl),
			 new Zensur("BWL", new DateTime(2017, 4, 13), 5, Leistungsart.KA),
			 new Zensur("BWL", new DateTime(2016, 9, 20), 3, Leistungsart.SA),
			 new Zensur("BWL", new DateTime(2017, 5, 14), 4, Leistungsart.SA),
			 new Zensur("BWL", new DateTime(2017, 6, 28), 2, Leistungsart.KA),
			 new Zensur("E", new DateTime(2017, 3, 13), 2, Leistungsart.KA),
			 new Zensur("E", new DateTime(2017, 10, 22), 4, Leistungsart.SA),
			 new Zensur("E", new DateTime(2017, 5, 19), 3, Leistungsart.KA),
			 new Zensur("E", new DateTime(2017, 6, 20), 3, Leistungsart.SA),
			 new Zensur("E", new DateTime(2016, 11, 29), 3, Leistungsart.KA),
			 new Zensur("M", new DateTime(2016, 10, 13), 1, Leistungsart.KA),
			 new Zensur("M", new DateTime(2016, 12, 7), 3, Leistungsart.SA),
			 new Zensur("M", new DateTime(2017, 4, 9), 3, Leistungsart.KA),
			 new Zensur("M", new DateTime(2017, 6, 1), 2, Leistungsart.SA),
			 new Zensur("M", new DateTime(2017, 7, 3), 2, Leistungsart.mdl),
			 new Zensur("Abap", new DateTime(2016, 11, 19), 4, Leistungsart.KA),
			 new Zensur("Abap", new DateTime(2017, 4, 22), 3, Leistungsart.KA)
		};
		}

		#endregion

		#region Methods
		public void Add(Zensur zensur)
		{
			_zensuren.Add(zensur);
		}

		public IEnumerable<Zensur> GetAll()
		{
			return _zensuren;
		}

		public void SaveChanges()
		{
			// es gibt nichts zu tun, da die Objekte ausschließlich im Arbeitsspeicher gehalten werden...
			return;
		}
		#endregion
	}
}
