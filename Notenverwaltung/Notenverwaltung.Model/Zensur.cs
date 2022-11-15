using System;
namespace Notenverwaltung.Model
{
	public class Zensur : IComparable<Zensur>
	{
		#region Properties
		public string Fach { get; set; }
		public DateTime Datum { get; set; }
		public int Note { get; set; }

		public Leistungsart Art { get; set; }

		#endregion

		#region Constructors
		public Zensur(string fach, DateTime datum, int note, Leistungsart leistungsart)
		{
			Fach = fach;
			Datum = datum;
			Note = note;
			Art = leistungsart;
		}
		public Zensur() : this(String.Empty, DateTime.Today, 1, Leistungsart.KA) { }

		public int CompareTo(Zensur? other)
		{
			int result = 0;
			if (other != null)
			{
				result = this.Fach.CompareTo(other.Fach);
				if (result == 0)
				{
					result = this.Datum.CompareTo(other.Datum);
				}
			}
			else
			{
				result = 1;
			}

			return result;
		}

		#endregion
	}
}
