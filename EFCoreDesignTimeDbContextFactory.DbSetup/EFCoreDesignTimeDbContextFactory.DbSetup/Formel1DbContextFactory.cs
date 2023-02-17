using EFCoreDesignTimeDbContextFactory.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreDesignTimeDbContextFactory.DbSetup;

public class Formel1DbContextFactory : IDesignTimeDbContextFactory<Formel1DbContext>
{
	public Formel1DbContext CreateDbContext(string[] args)
	{
		string connString = Environment.GetEnvironmentVariable("FORMEL1_ADMIN")
			?? throw new ArgumentNullException(nameof(connString),"Bitte Umgebungsvariable FORMEL1_ADMIN setzen");

		var optionsBuilder = new DbContextOptionsBuilder<Formel1DbContext>();
		optionsBuilder.UseSqlServer(connString);

		return new Formel1DbContext(optionsBuilder.Options);
	}
}
