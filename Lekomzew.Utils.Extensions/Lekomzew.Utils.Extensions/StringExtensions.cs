namespace Lekomzew.Utils.Extensions
{
	public static  class StringExtensions
	{
		public static bool IsNullOrEmpy(this string zeichenkette)
		{
			return String.IsNullOrEmpty(zeichenkette);
		}

		public static bool IsInt32(this string zeichenkette)
		{
			return Int32.TryParse(zeichenkette, out _);
		}

		public static string FormatWith(this string zeichenkette, params object[] args)
		{
			return String.Format(zeichenkette, args);
		}

		public static string Left(this string zeichenkette, int anzahl)
		{
			if (zeichenkette.Length > anzahl)
			{
				return zeichenkette;
			}
			return zeichenkette[1..anzahl];
		}

		public static string Right(this string zeichenkette, int anzahl)
		{
			return zeichenkette[^1..anzahl];
		}
		
		public static string TrimToMaxLength(this string zeichenkette, int anzahl)
		{
			return zeichenkette.Trim().Left(anzahl);
		}

		public static string WordCount(this string zeichenkette)
		{
			char[] chars = { ' ' , '.',',','?','!'};
			//return zeichenkette.Split(chars).Length;
		}
	}
}