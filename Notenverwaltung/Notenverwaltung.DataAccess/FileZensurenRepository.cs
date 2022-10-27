using Notenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenverwaltung.DataAccess
{
	public class FileZensurenRepository : IZensurenRepository
	{
		private List<Zensur> _zensuren;
		public string DataiPfad { get; }

		public FileZensurenRepository(string dataiPfad)
		{
			DataiPfad = dataiPfad;
			_zensuren = new();
		}

		public void Add(Zensur zensur)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Zensur> GetAll()
		{
			throw new NotImplementedException();
		}

		public void SaveChanges()
		{
			throw new NotImplementedException();
		}
	}
}
