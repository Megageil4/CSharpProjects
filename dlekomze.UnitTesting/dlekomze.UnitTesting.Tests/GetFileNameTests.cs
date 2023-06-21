using dlekomze.UnitTesting.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.UnitTesting.Tests
{
	[TestClass]
	public class GetFileNameTests
	{
		public void ShouldReturnFileName()
		{
			string path = "O:\\muster\\CSharp\\uebungen\\004_Path.html";
			string? expected = "004_Path";
			string? actual = StringMethoden.GetFileName(path);
			Assert.AreEqual(expected, actual);
		}
	}
}
