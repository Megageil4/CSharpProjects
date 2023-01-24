using dlekomze.BergInfo.Entity;
using Microsoft.EntityFrameworkCore;

namespace dlekomze.BergInfo.SqlServer
{
	public class BergInfoDbContext : DbContext
	{
		#region Properties
		public DbSet<Berg> BergSet { get; set; }
		#endregion

		#region Konstruktoren
		public BergInfoDbContext() : base() { }
		public BergInfoDbContext(DbContextOptions options) : base(options) { }
		#endregion

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Data Source=10.0.104.73;Initial Catalog=BFS2021fi_dlekomze;Persist Security Info=True;User ID=dlekomze;Password=abc;TrustServerCertificate=True");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("BergInfo");
			modelBuilder.Entity<Berg>().ToTable("Berg");
			modelBuilder.Entity<Berg>().HasIndex(b => b.Name).IsUnique();
			modelBuilder.Entity<Berg>().Property(b => b.Ersbesteigung).HasColumnType("date");
			modelBuilder.Entity<Berg>().HasData(new Berg(1,"Zugspitze",2962, null),new Berg(2,"K2",8672, null));
		}
	}
}