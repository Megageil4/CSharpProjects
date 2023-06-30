using System.Threading.Tasks;
using Uebung.TankenApp.Entity;

namespace Uebung.TankenApp.ViewModel
{
	public interface ITankenRepository
	{
		public Task Speichern(Tankvorgang tankvorgang);
	}
}