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
		public IEnumerable<Zensur> Zensuren { get; }
		private readonly IZensurenRepository _repository;
		public NotenManager(IZensurenRepository repository)
		{
			_repository = repository;
			//Zensuren = 
		}
	}
}
