using System;

namespace Demo.DependencyInjection.Model;

public class Stadion
{
	public int Id { get; set; }
	public string Bezeichnung { get; set; }
	public int Kapazitaet { get; set; }
	public string Stadt { get; set; }
	public string Land { get; set; }
	public DateTime? Eroeffnung { get; set; }

}
