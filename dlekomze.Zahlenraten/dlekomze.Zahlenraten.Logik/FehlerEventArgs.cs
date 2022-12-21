namespace dlekomze.Zahlenraten.Logik
{
	public class FehlerEventArgs
	{
		public bool Groesser { get; set; }

		public FehlerEventArgs(bool groesser)
		{
			Groesser = groesser;
		}
	}
}