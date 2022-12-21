namespace dlekomze.Zahlenraten.Logik;

public class Ratespiel
{
	private int _zahl;
	private int _currentVersuch;
	public int Untergrenze { get; set; }
	private int _Obergrenze;

	public int Obergrenze
	{
		get { return _Obergrenze; }
		set 
		{
			if (value < Untergrenze + 1)
			{
				throw new ArgumentException("Obergrenze muss um mindestens 1 größer sein als die Untergrenze");
			}
			_Obergrenze = value; 
		}
	}

	private int _MaxVersuche;

	public int MaxVersuche
	{
		get { return _MaxVersuche; }
		set 
		{
			value = Math.Clamp(value,1,10);
			_MaxVersuche = value; 
		}
	}

	public bool IstAktiv { get; private set; }

	public event EventHandler<GestartetEventArgs>? Gestartet;
	public event EventHandler<ErgebnisEventArgs>? Gewonnen;
	public event EventHandler<ErgebnisEventArgs>? Verloren;
	public event EventHandler<FehlerEventArgs>? Fehlversuch;
	public event EventHandler? NichtAktiv;
	public event EventHandler<ErgebnisEventArgs>? 
		Abgrebrochen;

	public Ratespiel(int untergrenze, int obergrenze, int maxVersuche)
	{
		Untergrenze = untergrenze;
		Obergrenze = obergrenze;
		MaxVersuche = maxVersuche;
	}

	public Ratespiel() : this(0,10,5) {}

	public void Starten()
	{
		Random random = new Random();
		_zahl = random.Next(Untergrenze, Obergrenze + 1);
		OnGestartet();
		IstAktiv = true;
		_currentVersuch = 0;
	}

	public void Raten(int zahl)
	{
		if (!IstAktiv)
		{
			OnNichtAktiv();
		}
		else
		{

			if (zahl == _zahl)
			{
				OnGewonnen(_currentVersuch);
				IstAktiv = false;
			}
			else
			{
				_currentVersuch++;
				if (_currentVersuch == MaxVersuche)
				{
					OnVerloren(_zahl);
					IstAktiv = false;
				}
				else
				{
					OnFehlversuch(zahl < _zahl);
				}
			}
		}
	}

	public void Abbrechen()
	{
		IstAktiv = false;
		OnAbgebrochen(_zahl);
	}

	protected virtual void OnGestartet()
	{
		Gestartet?.Invoke(this, new GestartetEventArgs(Untergrenze,Obergrenze,MaxVersuche));
	}


	protected virtual void OnGewonnen(int zahl)
	{
		Gewonnen?.Invoke(this, new ErgebnisEventArgs(zahl));
	}
	protected virtual void OnVerloren(int zahl)
	{
		Verloren?.Invoke(this, new ErgebnisEventArgs(zahl));
	}

	protected virtual void OnFehlversuch(bool groesser)
	{
		Fehlversuch?.Invoke(this, new FehlerEventArgs(groesser));
	}

	protected virtual void OnNichtAktiv()
	{
		NichtAktiv?.Invoke(this, EventArgs.Empty);
	}
	protected virtual void OnAbgebrochen(int zahl)
	{
		Abgrebrochen?.Invoke(this, new ErgebnisEventArgs(zahl));
	}
}