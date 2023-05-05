using CommunityToolkit.Mvvm.Input;
using dlekomze.Tilgungsrechner.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Tilgungsrechner.ViewModel
{
	public class TilgungViewModel
	{
		public double Darlehen { get; set; }
		public double AnfaenglicheTilgung { get; set; }
		public double Zinssatz { get; set; }
		public ObservableCollection<TilgungsZahlung> Tilgungen{ get; set; }
		public RelayCommand BerechneTilgungsplan { get; }
		public RelayCommand Initialisieren { get; set; }
		public double? Annunitaet 
		{ 
			get 
			{
				if (double.IsNaN(Darlehen))
				{
					return null;
				}
				return Darlehen * (AnfaenglicheTilgung / 100) + Darlehen * (Zinssatz / 100);
			}
		}


		public TilgungViewModel()
		{
			Tilgungen = new();
			BerechneTilgungsplan = new
				(
					() => 
					{
						decimal rest = (decimal)Darlehen;
						while (rest > 0)
						{
							decimal annunitaet = (decimal)Annunitaet;
							rest -= (decimal)Annunitaet;
							if (rest < 0)
							{
								annunitaet = (decimal)Annunitaet + rest;
								rest = 0;
							}
							//add
						}
						Tilgungen.Clear();
					},
					() => !double.IsNaN(Darlehen)
					   && !double.IsNaN(AnfaenglicheTilgung) 
					   && !double.IsNaN(Zinssatz));

			Initialisieren = new
				(
					() => 
					{
						Tilgungen.Clear();
						Darlehen = double.NaN;
						AnfaenglicheTilgung = double.NaN;
						Zinssatz = double.NaN;
					}
				);
		}
	}
}
