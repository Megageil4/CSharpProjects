using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.TankenApp
{
	public class TankBelegDBContextFactory : IDesignTimeDbContextFactory<TankBelegDBContext>
	{
		public TankBelegDBContext CreateDbContext(string[] args)
		{
			string connString = Environment.GetEnvironmentVariable("MSSQL_ADMIN", EnvironmentVariableTarget.User)
			?? throw new ArgumentNullException(nameof(connString), "Bitte setzen Sie die Umgebungsvariable MSSQL_ADMIN");

			var optionsBuilder = new DbContextOptionsBuilder<TankBelegDBContext>();
			optionsBuilder.UseSqlServer(connString);

			return new TankBelegDBContext(optionsBuilder.Options);
		}
	}
}
