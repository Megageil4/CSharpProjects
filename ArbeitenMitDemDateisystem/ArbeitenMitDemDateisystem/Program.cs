foreach (var drive in DriveInfo.GetDrives())
{
	if (drive.IsReady)
	{

		Console.WriteLine(drive.Name);
		Console.WriteLine(drive.TotalSize);
		Console.WriteLine(drive.AvailableFreeSpace);
		Console.WriteLine(drive.RootDirectory);
	}
}
 
if (!Directory.Exists(@"D:\Daten\dlekomze\myTemp"))
{
	Directory.CreateDirectory(@"D:\Daten\dlekomze\myTemp");
}

DirectoryInfo myTemp = new(@"D:\Daten\dlekomze\myTemp");
if (myTemp != null)
{ 
	myTemp.CreateSubdirectory("Sub1");
	myTemp.CreateSubdirectory("Sub2");
	myTemp.CreateSubdirectory("Sub3");
}

foreach (var file in Directory.GetFiles(@"H:\Daten", "*.txt"))
{
	Console.WriteLine(file);
}

DirectoryInfo daten = new(@"H:\Daten");
if (daten != null)
{
	foreach (var file in daten.EnumerateFiles("*.txt"))
	{
		Console.WriteLine(file.Name);
	}
}

Console.ReadKey();