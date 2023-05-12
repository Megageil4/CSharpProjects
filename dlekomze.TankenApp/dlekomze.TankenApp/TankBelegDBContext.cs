using dlekomze.TankenApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.TankenApp
{
	public class TankBelegDBContext : DbContext
	{
		public TankBelegDBContext() : base() { }
		public TankBelegDBContext(DbContextOptions<TankBelegDBContext> options) : base(options) { }
		public DbSet<Tankbeleg> TankbelegSet => Set<Tankbeleg>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("Tank");
			modelBuilder.Entity<Tankbeleg>().ToTable("Tankbeleg");
			modelBuilder.Entity<Tankbeleg>().Property(t => t.Datum).HasColumnType("date");
		}
	}
}
