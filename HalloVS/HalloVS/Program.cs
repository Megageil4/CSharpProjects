// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Unser erstes Programm mit Visual Studio!");

string eingabe = Console.ReadLine();
Ausgeben(eingabe);

void Ausgeben(string daten)
{
	Console.WriteLine($"Ihre Daten bestehen  aus {daten.Length} Zeichen");	
}