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
				int index = -1;
				switch (Occurance)
				{
					case ReplaceOccurance.First:
						index = file.IndexOf(SearchString);
						newFilename = Replace(file, SearchString, ReplaceString, index);
						break;
					case ReplaceOccurance.Last:
						index = file.LastIndexOf(SearchString);
						newFilename = Replace(file, SearchString, ReplaceString, index);
						break;
					case ReplaceOccurance.All:
						newFilename = file.Replace(SearchString, ReplaceString);
						break;
				}

				yield return newFilename;
			}
		}

		private static string Replace(string file, string search, string replace, int index)
		{
			string newFilename = "";
			if (index == -1)
			{
				return file;
				//throw new ArgumentException($"{file} does not contain {search}");
			}
			newFilename = file.Remove(index, search.Length);
			newFilename = newFilename.Insert(index, replace);

			return newFilename;
		}

		public override string ToString()
		{
			return $"Replace {SearchString} with {ReplaceString} ({Occurance})";
		}
	}
}
