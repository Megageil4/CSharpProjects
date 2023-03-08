using dlekomze.Zusatzstoffe.DbSetup;
using dlekomze.Zusatzstoffe.Enitity;
using dlekomze.Zusatzstoffe.SqlServer;

ZusatzstoffeDbFactory zusatzstoffeOptions = new ZusatzstoffeDbFactory();
ZusatzstoffeDbContext zusatzstoffeDb = zusatzstoffeOptions.CreateDbContext(new string[1]);
Stoff stoff1 = new Stoff(1, "Citronensäure", "Säurungsmittel auf pflanzlicher Basis. Natürliche Substanz im menschlichen Stoffwechsel. Wird mit Hilfe von Schimmelpilzen aus zuckerhaltigen Substanzen gewonnen. Kann auch gentechnisch hergestellt werden. Der zunehmende Einsatz in Getränken und \"sauren\" Süßigkeiten führt immer häufiger zu Zahnschäden bei Kindern und Erwachsenen, weil der Zahnschmelz von der Säure angegriffen wird, zum Beispiel durch Eistee in Nuckelflaschen für Kleinkinder. Auch für Bio-Lebensmittel zugelassen. Vom Verzehr in größeren Mengen ist abzuraten.", false, true, 1);
Stoff stoff2 = new Stoff(2, "Lecithin", "Lecithin verbessert die Knet- und Formeigenschaften von Teigen und verlangsamt das Altbackenwerden von Gebäck. In Margarine sorgt Lecithin dafür, dass sie in der Pfanne nicht spritzt.", true, true, 1);

//Herkunft herkunft1 = zusatzstoffeDb.HerkunftSet.Find(1) ?? throw new Exception();
//Herkunft herkunft2 = zusatzstoffeDb.HerkunftSet.Find(2) ?? throw new Exception();
//Herkunft herkunft3 = zusatzstoffeDb.HerkunftSet.Find(3) ?? throw new Exception();

//herkunft1.StoffSet.Add(stoff1);
//herkunft2.StoffSet.Add(stoff2);
//herkunft3.StoffSet.Add(stoff2);

//Verwendung verwendung1 = zusatzstoffeDb.verwendungSet.Find(1) ?? throw new Exception();
//Verwendung verwendung2 = zusatzstoffeDb.verwendungSet.Find(2) ?? throw new Exception();
//Verwendung verwendung3 = zusatzstoffeDb.verwendungSet.Find(3) ?? throw new Exception();
//Verwendung verwendung4 = zusatzstoffeDb.verwendungSet.Find(4) ?? throw new Exception();
//Verwendung verwendung5 = zusatzstoffeDb.verwendungSet.Find(5) ?? throw new Exception();

//verwendung1.StoffSet.Add(stoff1);
//verwendung2.StoffSet.Add(stoff2);
//verwendung3.StoffSet.Add(stoff2);
//verwendung4.StoffSet.Add(stoff2);
//verwendung5.StoffSet.Add(stoff2);
//stoff1.HerkunftSet.Add(herkunft1);
//stoff1.VerwendungSet.Add(verwendung1);
//stoff2.HerkunftSet.Add(herkunft2);
//stoff2.HerkunftSet.Add(herkunft3);
//stoff2.VerwendungSet.Add(verwendung2);
//stoff2.VerwendungSet.Add(verwendung3);
//stoff2.VerwendungSet.Add(verwendung4);
//stoff2.VerwendungSet.Add(verwendung5);

//zusatzstoffeDb.StoffSet.Add(stoff1);
//zusatzstoffeDb.StoffSet.Add(stoff2);

//zusatzstoffeDb.SaveChanges();

Console.WriteLine("");