namespace Devisenrechner.DataAccess
{
	public class EingelesenEventArgs
	{
		public int Anzahl { get; set; }

		public EingelesenEventArgs(int anzahl)
		{
			Anzahl = anzahl;
		}
	}
}