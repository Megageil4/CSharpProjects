using dlekomze.BergInfo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.BergInfo.SqlServer
{
	public class BergRepository : IBergRepository
	{
		private BergInfoDbContext _context;

		public BergRepository(BergInfoDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Berg> GetAll()
		{
			return _context.BergSet.AsEnumerable();
		}

		public Berg? Get(int id)
		{
			return GetAll().SingleOrDefault(b => b.ID == id);
		}

		public Berg? GetByName(string name)
		{
			return GetAll().SingleOrDefault(b => b.Name == name);
		}
	}
}
