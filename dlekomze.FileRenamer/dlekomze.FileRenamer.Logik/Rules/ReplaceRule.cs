using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.FileRenamer.Logik.Rules
{
	public class ReplaceRule : IRenameRule
	{
		public string SearchString { get; set; }
		public string ReplaceString { get; set; }
		public ReplaceOccurance Occurance { get; set; }

		public ReplaceRule(string searchString, string replaceString, ReplaceOccurance occurance)
		{
			SearchString = searchString;
			ReplaceString = replaceString;
			Occurance = occurance;
		}

		public IEnumerable<string> Rename(IEnumerable<string> filenames)
		{
			foreach (string file in filenames)
			{
				string newFilename = "";

				switch (Occurance)
				{
					case ReplaceOccurance.First:
						newFilename = ReplaceFirst(file, SearchString, ReplaceString);
						break;
					case ReplaceOccurance.Last:
						newFilename = ReplaceFirst((string)file.Reverse(), (string)SearchString.Reverse(), (string)ReplaceString.Reverse());
						break;
					case ReplaceOccurance.All:
						newFilename = file.Replace(SearchString, ReplaceString);
						break;
				}

				yield return newFilename;
			}
		}

		private static string ReplaceFirst(string file, string search, string replace)
		{
			string newFilename = "";
			int index = file.IndexOf(search);
			if (index == -1)
			{
				throw new ArgumentException($"{file} does not contain {search}");
			}
			newFilename = file.Remove(index, replace.Length);
			newFilename = file.Insert(index, replace);

			return newFilename;
		}

		public override string ToString()
		{
			return $"Replace {SearchString} with {ReplaceString} ({Occurance})";
		}
	}
}
