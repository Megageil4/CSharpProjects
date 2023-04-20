using Demo.ControlsFuerCollections.Model;
using System.Collections.Generic;

namespace Demo.ControlsFuerCollections.Data;

public class SchuelerDataProvider
{
	public IEnumerable<Schueler> GetAll()
	{
		yield return new Schueler() { Id = 1, Nachname = "Müller", Vorname = "Franziska", Klasse = "B10a" };
		yield return new Schueler() { Id = 2, Nachname = "Schneider", Vorname = "Hans", Klasse = "B11b" };
		yield return new Schueler() { Id = 3, Nachname = "Schubert", Vorname = "Johanna", Klasse = "B10b" };
		yield return new Schueler() { Id = 4, Nachname = "Böhm", Vorname = "Rainer", Klasse = "B10a" };
		yield return new Schueler() { Id = 5, Nachname = "Deinberger", Vorname = "Andrea", Klasse = "B10a" };
		yield return new Schueler() { Id = 6, Nachname = "Fuchsgruber", Vorname = "Karl-Heinz", Klasse = "B10b" };
		yield return new Schueler() { Id = 7, Nachname = "Stern", Vorname = "Raffaela", Klasse = "B10b" };
		yield return new Schueler() { Id = 8, Nachname = "Hopfeneder", Vorname = "Valentin", Klasse = "B10a" };
		yield return new Schueler() { Id = 9, Nachname = "Binder", Vorname = "Gerhard", Klasse = "B11a" };
		yield return new Schueler() { Id = 10, Nachname = "Eckmüller", Vorname = "Eduard", Klasse = "B11a" };
		yield return new Schueler() { Id = 11, Nachname = "Gerbauer", Vorname = "Christina", Klasse = "B11b" };
	}
}
