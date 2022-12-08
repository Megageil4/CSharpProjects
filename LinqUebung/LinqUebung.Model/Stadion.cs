namespace LinqUebung.Model
{
	public class Stadion
	{
		public int ID { get; set; }
		public string Bezeichnung { get; set; }
		public int? Kapazitaet { get; set; }
		public string Stadt { get; set; }
		public string Land { get; set; }
		public DateTime? Eroeffnung { get; set; }

		public Stadion(int id, string bezeichnung, int? kapazitaet, string stadt, string land, DateTime? eroeffnung)
		{
			ID = id;
			Bezeichnung = bezeichnung;
			Kapazitaet = kapazitaet;
			Stadt = stadt;
			Land = land;
			Eroeffnung = eroeffnung;
		}

		public override string ToString()
		{
			return $"{ID}, {Bezeichnung}, {Kapazitaet}, {Stadt}, {Land}, {Eroeffnung:d}";
		}
	}
}