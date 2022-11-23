using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.FileRenamer.Logik.Rules
{
	public class ExtensionRule : IRenameRule
	{
		private string _newExtension;

		public string NewExtension
		{
			get { return _newExtension; }
			set
			{
				string extension = value;
				while ( extension[0] == '.')
				{
					extension = extension.Remove(0, 1);
				}
				_newExtension = extension;
			}
		}

		public bool Append { get; set; }

		public ExtensionRule(string newExtension, bool append = false)
		{
			_newExtension = "";
			NewExtension = newExtension;
			Append = append;
		}

		public IEnumerable<string> Rename(IEnumerable<string> filenames)
		{
			foreach (var file in filenames)
			{
				string filename = Path.GetFileNameWithoutExtension(file);
				if (Append)
				{
					filename = file;
				}

				yield return $"{filename}.{NewExtension}";
			}
		}

		public override string ToString()
		{
			return $"New Extension {NewExtension} ({(Append ? "replace" : "append")})";
		}
	}
}
