using dlekomze.FileRenamer.Logik;
using dlekomze.FileRenamer.Logik.Rules;
using System.IO;

FileNameManager fileNameManager = new();

string[] files = Directory.GetFiles(@"D:\Daten\dlekomze\git\csharp\uebungen\dlekomze.FileRenamer\FileRenamer.UI\Files");

fileNameManager.AddRule(new ReplaceRule("Text", "newText", ReplaceOccurance.Last));
fileNameManager.AddRule(new ExtensionRule("..newEx"));
fileNameManager.FilesToRename.AddRange(files);
foreach (var s in fileNameManager.Preview)
{
	Console.WriteLine(s);
}

fileNameManager.Rename();

Console.ReadKey();