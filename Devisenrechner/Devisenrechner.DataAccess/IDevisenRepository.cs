using Devisenrechner.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devisenrechner.DataAccess
{
	public interface IDevisenRepository
	{
		public event EventHandler? Einlesen;

		public event EventHandler<FehlerEventArgs>? Lesefehler;

		public event EventHandler<EingelesenEventArgs>? Eingelesen;

		IEnumerable<Waehrung> GetAll();

		Waehrung? GetByKuerzel(string kuerzel);
	}
}
