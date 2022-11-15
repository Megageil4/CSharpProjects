using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notenverwaltung.DataAccess;
using Notenverwaltung.Model;

namespace Notenverwaltung.Logik
{
	public class NotenManager
	{
		public IEnumerable<Zensur> Zensuren { get; private set;  }
		private readonly IZensurenRepository _repository;
		private IDurchschnittRechner _durchschnittRechner;

		public IDurchschnittRechner DurchschnittRechner
		{
			get { return _durchschnittRechner; }
			set 
			{
				_durchschnittRechner = value ?? throw new ArgumentNullException("DurchschnittRechner darf nicht NULL sein");
			}
		}

		public NotenManager(IZensurenRepository repository)
		{
			_repository = repository;
			Zensuren = _repository.GetAll();
			_durchschnittRechner = new StandardDurchschnittRechner();
		}

		public IEnumerable<Zensur> ZensurenImFach(string fach)
		{
			foreach (var note in Zensuren)
			{
				if (note.Fach == fach)
				{
					yield return note;
				}
			}
		}

		public double BerechneDurchschnitt(string fach)
		{
			return DurchschnittRechner.BerechnenDurchschnitt(ZensurenImFach(fach));
		}

		public void HinzufuegenZensur(Zensur zensur)
		{
			_repository.Add(zensur);
			Zensuren = _repository.GetAll();
		}
	}
}
