using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Uebung.TankenApp.SqlServer;

public class DesignTimeTankenDbContextFactory : IDesignTimeDbContextFactory<TankenDbContext>
{
	public TankenDbContext CreateDbContext(string[] args)
	{
		var builder = new DbContextOptionsBuilder<TankenDbContext>();
		// DesignTime-ConnectionString der Einfachheit halber hart codiert
		// --> an Ihre eigenen Zugangsdaten anpassen
		builder.UseSqlServer("Data Source=10.0.104.73;Initial Catalog=bfs2021fi_dlekomze;User ID=dlekomze;Password=abc;TrustServerCertificate=True"); 
		return new TankenDbContext(builder.Options);
	}
}

