using dlekomze.UnitTesting.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.UnitTesting.Tests
{
	[TestClass]
	public class GetPathWithoutExtensionTests
	{
		[TestMethod]
		public void ShouldReturnNullBecauseInputWrong()
		{
			string path = "O:\\muster\\CSharp\\uebungen_004_Path";
			string? expected = null;
			string? actual = StringMethoden.GetFilePathWithoutExtension(path);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ShouldReturnNullBecauseInputNull()
		{
#pragma warning disable CS8604
			string? path = null;
			string? expected = null;
			string? actual = StringMethoden.GetFilePathWithoutExtension(path);
			Assert.AreEqual(expected, actual);
#pragma warning restore CS8604
		}

		[TestMethod]
		public void ShouldReturnFilePathWithoutExtension()
		{
			string path = "O:\\muster\\CSharp\\uebungen_004_Path.html";
			string? expected = "O:\\muster\\CSharp\\uebungen_004_Path";
			string? actual = StringMethoden.GetFilePathWithoutExtension(path);
			Assert.AreEqual(expected, actual);
		}
	}
}
