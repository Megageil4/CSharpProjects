namespace Devisenrechner.DataAccess
{
	public class FehlerEventArgs : EventArgs
	{
		public string Zeile { get; set; }

		public FehlerEventArgs(string zeile)
		{
			Zeile = zeile;
		}
	}
}