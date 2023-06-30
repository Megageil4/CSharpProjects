using Microsoft.EntityFrameworkCore;
using Uebung.TankenApp.Entity;

namespace Uebung.TankenApp.SqlServer;

public class TankenDbContext : DbContext
{
	public TankenDbContext() { }
	public TankenDbContext(DbContextOptions<TankenDbContext> options)
	: base(options)
	{
	}
	public DbSet<Tankvorgang> TankvorgangSet => Set<Tankvorgang>();

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder
			.Entity<Tankvorgang>()
			.ToTable("Tankvorgang", "dbo");
		modelBuilder
			.Entity<Tankvorgang>()
			.Property(p => p.Preis)
			.HasColumnType("money");
	}
}
