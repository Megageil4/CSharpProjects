using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.UnitTesting.UI
{
	public class StringMethoden
	{
		public static string? GetFilePathWithoutExtension(string path)
		{
			if (string.IsNullOrEmpty(path)
			 || string.IsNullOrWhiteSpace(path))
			{
				return null;
			}

			int index = path.LastIndexOf('.');
			if (index == -1)
			{
				return null;
			}

			return path.Remove(index);
		}

		public static string GetDirectoryName(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				return "";
			}

			int pos = path.Length - 1;

			while (pos > 0 && path[--pos] != Path.DirectorySeparatorChar) ;

			return path.Substring(pos).Replace(Path.DirectorySeparatorChar.ToString(),"");
		}
	}
}
