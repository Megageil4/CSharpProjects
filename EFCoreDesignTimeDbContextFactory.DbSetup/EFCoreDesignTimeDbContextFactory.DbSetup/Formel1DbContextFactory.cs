using EFCoreDesignTimeDbContextFactory.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCoreDesignTimeDbContextFactory.DbSetup;

public class Formel1DbContextFactory : IDesignTimeDbContextFactory<Formel1DbContext>
{
	public Formel1DbContext CreateDbContext(string[] args)
	{
		throw new NotImplementedException();
	}
}
