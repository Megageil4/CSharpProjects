using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.FileRenamer.Logik.Rules
{
	public abstract class InsertRule : IRenameRule
	{
		private int _position;

		public int Position
		{
			get { return _position; }
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				_position = value;
			}
		}

		public bool AsLast { get; set; }

		protected InsertRule(int position, bool asLast = false)
		{
			Position = position;
			AsLast = asLast;
		}

		protected string InsertIntoFilename(string filepath, string insert)
		{
			if (AsLast || filepath.Length - 1 < Position)
			{
				Position = filepath.Length - 1;
			}

			filepath = filepath.Insert(Position, insert);
			return filepath;
		}

		public abstract IEnumerable<string> Rename(IEnumerable<string> filenames);
	}
}
