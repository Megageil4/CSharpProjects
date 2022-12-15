namespace ArbeitenMitEreignissen;

public class ErgebnisEventArgs : EventArgs
{
	public long Ergebnis { get; set; }
	public DateTime Zeitpunkt { get; set; }

	public ErgebnisEventArgs(long ergebnis, DateTime zeitpunkt) : base()
	{
		Ergebnis = ergebnis;
		Zeitpunkt = zeitpunkt;
	}

	public ErgebnisEventArgs(long ergebnis) : this(ergebnis, DateTime.Now) {}

	
}
