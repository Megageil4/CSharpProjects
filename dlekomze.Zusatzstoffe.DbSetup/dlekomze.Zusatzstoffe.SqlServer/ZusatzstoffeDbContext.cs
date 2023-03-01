using dlekomze.Zusatzstoffe.Enitity;
using Microsoft.EntityFrameworkCore;

namespace dlekomze.Zusatzstoffe.SqlServer;

public class ZusatzstoffeDbContext : DbContext
{
	public DbSet<Bewertung> BewertungSet => Set<Bewertung>();
	public DbSet<Herkunft> HerkunftSet => Set<Herkunft>();
	public DbSet<Stoff> StoffSet => Set<Stoff>();
	public DbSet<Verwendung> verwendungSet => Set<Verwendung>();

	public ZusatzstoffeDbContext() : base() {}
	public ZusatzstoffeDbContext(DbContextOptions options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasDefaultSchema("ENummern");
		modelBuilder.Entity<Bewertung>().ToTable("Bewertung");
		modelBuilder.Entity<Herkunft>().ToTable("Herkunft");
		modelBuilder.Entity<Stoff>().ToTable("Stoff");
		modelBuilder.Entity<Verwendung>().ToTable("Verwendung");

		Bewertung bewertung1 = new Bewertung(1, "unbedenklich");
		Herkunft herkunft1 = new Herkunft(1, "künstlich");
		Herkunft herkunft2 = new Herkunft(2, "pflanzlich");
		Herkunft herkunft3 = new Herkunft(3, "tierisch");
		Verwendung verwendung1 = new Verwendung(1, "Säurungsmittel", "Stoffe, die ein Lebensmittel ansäuern und/oder diesem einen sauren Geschmack verleihen");
		Verwendung verwendung2 = new Verwendung(2, "Emulgator", "verbinden Stoffe, die nicht miteinander mischbar sind, wie zum Beispiel Öl und Wasser");
		Verwendung verwendung3 = new Verwendung(3, "Antioxidationsmittel", "verhindern das Ranzigwerden von Fetten und sorgen für eine längere Haltbarkeit");
		Verwendung verwendung4 = new Verwendung(4, "Stabilisator", "werden dazu verwendet, die Lebensmitteln zu stabilisieren, erhalten oder intensivieren");
		Verwendung verwendung5 = new Verwendung(5, "Mehlbehandlungsmittel", "???");
		Stoff stoff1 = new Stoff(1, "Citronensäure", "Säurungsmittel auf pflanzlicher Basis. Natürliche Substanz im menschlichen Stoffwechsel. Wird mit Hilfe von Schimmelpilzen aus zuckerhaltigen Substanzen gewonnen. Kann auch gentechnisch hergestellt werden. Der zunehmende Einsatz in Getränken und \"sauren\" Süßigkeiten führt immer häufiger zu Zahnschäden bei Kindern und Erwachsenen, weil der Zahnschmelz von der Säure angegriffen wird, zum Beispiel durch Eistee in Nuckelflaschen für Kleinkinder. Auch für Bio-Lebensmittel zugelassen. Vom Verzehr in größeren Mengen ist abzuraten.", false, true, 1);
		Stoff stoff2 = new Stoff(2, "Lecithin", "Lecithin verbessert die Knet- und Formeigenschaften von Teigen und verlangsamt das Altbackenwerden von Gebäck. In Margarine sorgt Lecithin dafür, dass sie in der Pfanne nicht spritzt.", true, true, 1);
		herkunft1.StoffSet.Add(stoff1);
		herkunft2.StoffSet.Add(stoff2);
		herkunft3.StoffSet.Add(stoff2);

		verwendung1.StoffSet.Add(stoff1);
		verwendung2.StoffSet.Add(stoff2);
		verwendung3.StoffSet.Add(stoff2);
		verwendung4.StoffSet.Add(stoff2);
		verwendung5.StoffSet.Add(stoff2);
		stoff1.HerkunftSet.Add(herkunft1);
		stoff1.VerwendungSet.Add(verwendung1);
		stoff2.HerkunftSet.Add(herkunft2);
		stoff2.HerkunftSet.Add(herkunft3);
		stoff2.VerwendungSet.Add(verwendung2);
		stoff2.VerwendungSet.Add(verwendung3);
		stoff2.VerwendungSet.Add(verwendung4);
		stoff2.VerwendungSet.Add(verwendung5);
		modelBuilder.Entity<Verwendung>().HasData(verwendung1, verwendung2, verwendung3, verwendung4, verwendung5);
		modelBuilder.Entity<Herkunft>().HasData(herkunft1, herkunft2, herkunft3);
		modelBuilder.Entity<Bewertung>().HasData(bewertung1);
		modelBuilder.Entity<Stoff>().HasData(stoff1, stoff2);
	}
}
 