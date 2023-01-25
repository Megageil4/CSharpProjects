using dlekomze.BergInfo.Entity;

namespace dlekomze.BergInfo.SqlServer
{
	public interface IBergRepository
	{
		Berg? Get(int id);
		IEnumerable<Berg> GetAll();
		Berg? GetByName(string name);
	}
}