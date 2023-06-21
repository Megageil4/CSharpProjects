using dlekomze.UnitTesting.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.UnitTesting.Tests
{
	[TestClass]
	public class GetDirectoryNameTests
	{
		[TestMethod]
		public void ShouldReturnDirectoryName()
		{
			string path = "O:\\muster\\CSharp\\uebungen\\";
			string? expected = "uebungen";
			string? actual = StringMethoden.GetDirectoryName(path);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ShouldReturnEmptyBecauseNull()
		{
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
			string? path = null;
			string? expected = "";
			string? actual = StringMethoden.GetDirectoryName(path);
			Assert.AreEqual(expected, actual);
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
		}

		[TestMethod]
		public void ShouldReturnEmptyBecauseNoDir()
		{
			string path = "\\";
			string? expected = "";
			string? actual = StringMethoden.GetDirectoryName(path);
			Assert.AreEqual(expected, actual);
		}
	}
}
