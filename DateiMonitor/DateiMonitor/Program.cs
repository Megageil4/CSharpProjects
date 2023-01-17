string path;
while (true)
{
	Console.Write(@"Zu überwachendes Verzeichnis [H:\Daten]: ");
	path = Console.ReadLine() ?? "";
	path = path == "" ? @"H\Daten" : path;
	if (Directory.Exists(path))
	{
		break;
	} 
}
FileSystemWatcher fileSystemWatcher = new(path);
fileSystemWatcher.Changed += ((sender, e) => Console.WriteLine($"Datei \"{e.FullPath}\" wurde geändert"));
fileSystemWatcher.Created += ((sender, e) => Console.WriteLine($"Neu erstellt: \"{e.FullPath}\""));
fileSystemWatcher.Deleted += ((sender, e) => Console.WriteLine($"Gelöscht: \"{e.FullPath}\""));
fileSystemWatcher.Error += ((sender, e) => Console.WriteLine($"Fehler beim überfachen der Pfades: {e}"));
fileSystemWatcher.Renamed += ((sender, e) => Console.WriteLine($"Datei \"{e.OldFullPath}\" umbenannt in \"{e.FullPath}\""));

fileSystemWatcher.EnableRaisingEvents = true;
Console.WriteLine($"Überwachung für das Verzeichnis \"{path}\" gestartet...");
Console.WriteLine("Zum Beenden bitte eine beliebige Taste drücken");
Console.ReadKey();