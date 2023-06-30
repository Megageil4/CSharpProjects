using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uebung.TankenApp.Entity;
using Uebung.TankenApp.SqlServer;

namespace Uebung.TankenApp.ViewModel
{
	public class TankenDbRepositiory : ITankenRepository
	{
		public async Task Speichern(Tankvorgang tankvorgang)
		{

			using var db = CreateDbContext();

			Tankvorgang neuerTankvorgang = tankvorgang;

			db.TankvorgangSet.Add(neuerTankvorgang);
			await db.SaveChangesAsync();
		}

		private TankenDbContext CreateDbContext()
		{
			var builder = new DbContextOptionsBuilder<TankenDbContext>();
			// RunTime-ConnectionString der Einfachheit halber hart codiert
			// --> an Ihre eigenen Zugangsdaten anpassen
			builder.UseSqlServer("Data Source=10.0.104.73;Initial Catalog=bfs2021fi_dlekomze;User ID=dlekomze;Password=abc;TrustServerCertificate=True");
			return new TankenDbContext(builder.Options);
		}
	}
}
