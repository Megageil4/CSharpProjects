using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.FileRenamer.Logik.Rules
{
	public class FixedStringInsertRule : InsertRule
	{
		public string InsertString { get; set; }

		public FixedStringInsertRule(int position, string insertString, bool asLast = false ) : base(position, asLast)
		{
			InsertString = insertString;
		}

		public override IEnumerable<string> Rename(IEnumerable<string> filenames)
		{
			foreach (var file in filenames)
			{
				yield return InsertIntoFilename(file, InsertString);
			}
		}

		public override string ToString()
		{
			return $"FixedStringInsert {InsertString} at Position {Position}";
		}
	}
}
