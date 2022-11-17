using dlekomze.FileRenamer.Logik;
using dlekomze.FileRenamer.Logik.Rules;
using System.IO;

FileNameManager fileNameManager = new();

string[] files = Directory.GetFiles(@"D:\Daten\dlekomze\git\csharp\uebungen\dlekomze.FileRenamer\FileRenamer.UI\Files");

fileNameManager.AddRule(new ReplaceRule("Text", "newText", ReplaceOccurance.First));
fileNameManager.FilesToRename.AddRange(files);
foreach (var s in fileNameManager.Preview)
{

}

Console.ReadKey();