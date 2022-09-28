using Lekomzew.Utils.Extensions;

string eingabe = Console.ReadLine() ?? String.Empty;
if (eingabe.IsNullOrEmpy())
{
	Console.WriteLine("Sie haben nichts eingegeben!");
}
else if (eingabe.IsInt32())
{
	Console.WriteLine(eingabe.Left(20));
	string ausgabe = "Ihre Eingabe \"{0}\" ist eine ganze Zahl".FormatWith(eingabe);
	Console.WriteLine(ausgabe);
}
else
{
	Console.WriteLine("Die Eingabe war keine ganze Zahl");
}
Console.ReadKey();