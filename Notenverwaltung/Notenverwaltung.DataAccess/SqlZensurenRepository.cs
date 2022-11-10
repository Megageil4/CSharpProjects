using Notenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenverwaltung.DataAccess
{
	public class SqlZensurenRepository : IZensurenRepository
	{
		Datenbank db;

		public SqlZensurenRepository(string connectionString)
		{
			db = new(connectionString);
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
