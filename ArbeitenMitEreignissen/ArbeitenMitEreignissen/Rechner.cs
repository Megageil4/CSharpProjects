namespace ArbeitenMitEreignissen;

public class Rechner
{
	public event EventHandler? BerechnungGestarted;
	public event EventHandler? BerechnungBeendet;
	public event EventHandler<ErgebnisEventArgs>? Zwischenergebnis;

	public long BerechnenSumme(int untergrenze, int obergrenze)
	{
		OnBerechnungGestarted();
		long summe = 0;
		for (int i = untergrenze; i <= obergrenze; i++)
		{
			summe += i;
			if (i % 5 == 0)
			{
				OnZwischenergebnis(summe);
			}
			Thread.Sleep(1000);
		}
		OnBerechnungBeendet();
		return summe;
	}

	protected virtual void OnBerechnungBeendet()
	{
		BerechnungBeendet?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnBerechnungGestarted()
	{
		BerechnungGestarted?.Invoke(this, EventArgs.Empty);
	}
	protected virtual void OnZwischenergebnis(long ergebnis)
	{
		Zwischenergebnis?.Invoke(this, new ErgebnisEventArgs(ergebnis));
	}
}
