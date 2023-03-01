using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlekomze.Zusatzstoffe.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace dlekomze.Zusatzstoffe.DbSetup
{
	public class ZusatzstoffeDbFactory : IDesignTimeDbContextFactory<ZusatzstoffeDbContext>
	{
		public ZusatzstoffeDbContext CreateDbContext(string[] args)
		{
			string connString = Environment.GetEnvironmentVariable("FORMEL1_ADMIN",EnvironmentVariableTarget.User)
			?? throw new ArgumentNullException(nameof(connString), "Bitte Umgebungsvariable FORMEL1_ADMIN setzen");

			var optionsBuilder = new DbContextOptionsBuilder<ZusatzstoffeDbContext>();
			optionsBuilder.UseSqlServer(connString);

			return new ZusatzstoffeDbContext(optionsBuilder.Options);
		}
	}
}
