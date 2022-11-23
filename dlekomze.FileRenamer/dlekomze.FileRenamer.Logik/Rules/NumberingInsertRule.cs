using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.FileRenamer.Logik.Rules
{
	public class NumberingInsertRule : InsertRule
	{
		public int StartWith { get; set; }

		public NumberingInsertRule(int position,int startWith, bool asLast = false) : base(position, asLast)
		{
			throw new NotImplementedException();
		}

		public override IEnumerable<string> Rename(IEnumerable<string> filenames)
		{
			throw new NotImplementedException();
		}
	}
}
