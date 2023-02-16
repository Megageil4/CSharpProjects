using EFCoreDesignTimeDbContextFactory.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDesignTimeDbContextFactory.SqlServer;

public class Formel1DbContext : DbContext
{

	#region Properties
	public DbSet<Team> TeamSet => Set<Team>();
	#endregion


	#region Konstruktoren
	public Formel1DbContext() : base() { }
	public Formel1DbContext(DbContextOptions options) : base(options) { }
	#endregion

	#region Methoden
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasDefaultSchema("Formel1");
		modelBuilder.Entity<Team>().ToTable("Team");
		modelBuilder.Entity<Team>()
			.HasData(
				new Team() { Id = 1, Bezeichnung = "Red Bull" },
				new Team() { Id = 2, Bezeichnung = "Mercedes" },
				new Team() { Id = 3, Bezeichnung = "Ferrari" }
			);
	}
	#endregion
}