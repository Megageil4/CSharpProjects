using ArbeitenMitEFCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace ArbeitenMitEFCore.SqlServer;

public class SchuleDbContext : DbContext
{
	#region Properties
	public DbSet<Schueler> SchuelerSet { get; set; }
	public DbSet<Fehlzeit> FehlzeitSet { get; set; }
	public DbSet<Arbeitsgruppe> ArbeitsgruppeSet { get; set; }
	public DbSet<Vortrag> VortragSet { get; set; }
	public DbSet<Anmeldung> AnmeldungSet { get; set; }
	#endregion

	#region Konstruktoren
	public SchuleDbContext() : base() {}
	public SchuleDbContext(DbContextOptions options) : base(options) {}
	#endregion

	#region Methoden
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasDefaultSchema("Schule");
		modelBuilder.Entity<Schueler>().ToTable("Schueler");
		modelBuilder.Entity<Schueler>().Property(c => c.Geburtsdatum).HasColumnType("date");
		modelBuilder.Entity<Schueler>().HasIndex(c => c.Kennung).IsUnique();

		modelBuilder.Entity<Fehlzeit>().ToTable("Fehlzeit");

		modelBuilder.Entity<Arbeitsgruppe>().ToTable("Arbeitsgruppe");

		modelBuilder.Entity<Vortrag>().ToTable("Vortrag");

		modelBuilder.Entity<Anmeldung>().ToTable("Anmeldung");
		modelBuilder.Entity<Anmeldung>().HasKey(a => new { a.SchuelerId, a.VortragId});
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseSqlServer("Data Source=10.0.104.73;Initial Catalog=BFS2021fi_dlekomze;Persist Security Info=True;User ID=dlekomze;Password=abc;TrustServerCertificate=True");
		}
	}
	#endregion
}
