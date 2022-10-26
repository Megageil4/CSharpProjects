using Notenverwaltung.Model;

namespace Notenverwaltung.DataAccess
{
	public interface IZensurenRepository
	{
		void Add(Zensur zensur);
		IEnumerable<Zensur> GetAll();
		void SaveChanges();
	}
}