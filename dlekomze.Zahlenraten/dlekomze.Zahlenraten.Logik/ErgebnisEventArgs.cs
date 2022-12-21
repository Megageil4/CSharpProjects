namespace dlekomze.Zahlenraten.Logik
{
	public class ErgebnisEventArgs : EventArgs
	{
		public int Zahl { get; set; }

		public ErgebnisEventArgs(int zahl)
		{
			Zahl = zahl;
		}
	}
}