using CommunityToolkit.Mvvm.Input;
using dlekomze.Tilgungsrechner.Model;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Tilgungsrechner.ViewModel
{
	public class TilgungViewModel : INotifyPropertyChanged
	{
		private double darlehen;
		private double anfaenglicheTilgung;
		private double zinssatz;

		public double Darlehen
		{
			get => darlehen; 
			set
			{
				if (darlehen != value)
				{
					darlehen = value;
					OnPropertyChanged();
					OnPropertyChanged(nameof(Annunitaet));
					BerechneTilgungsplanCommand.NotifyCanExecuteChanged();
				}
			}
		}
		public double AnfaenglicheTilgung
		{
			get => anfaenglicheTilgung;
			set
			{
				if (anfaenglicheTilgung != value)
				{
					anfaenglicheTilgung = value;
					OnPropertyChanged();
					OnPropertyChanged(nameof(Annunitaet));
					BerechneTilgungsplanCommand.NotifyCanExecuteChanged();
				}
			}
		}
		public double Zinssatz 
		{ 
			get => zinssatz;
			set
			{
				if (zinssatz != value)
				{
					zinssatz = value;
					OnPropertyChanged();
					OnPropertyChanged(nameof(Annunitaet));
					BerechneTilgungsplanCommand.NotifyCanExecuteChanged();
				}
			}
		}
		public ObservableCollection<TilgungsZahlung> Tilgungen { get; set; }
		public RelayCommand BerechneTilgungsplanCommand { get; }
		public RelayCommand InitialisierenCommand { get; }
		public double? Annunitaet
		{
			get
			{
				if (double.IsNaN(Darlehen)
				 || double.IsNaN(AnfaenglicheTilgung)
				 || double.IsNaN(Zinssatz))
				{
					return null;
				}
				return Darlehen * (AnfaenglicheTilgung / 100) + Darlehen * (Zinssatz / 100);
			}
		}


		public TilgungViewModel()
		{
			Tilgungen = new();
			BerechneTilgungsplanCommand = new
				(
					() =>
					{
						Tilgungen.Clear();
						decimal rest = (decimal)Darlehen;
						decimal lastRest = rest;
						int jahr = 1;
						while (rest > 0)
						{
							decimal annunitaet = (decimal)Annunitaet;
							rest -= (decimal)Annunitaet;
							decimal zinsen = lastRest * (decimal)(Zinssatz / 100.0);
							rest += zinsen;
							if (rest < 0)
							{
								annunitaet = (decimal)Annunitaet + rest;
								rest = 0;
							}
							Tilgungen.Add(new TilgungsZahlung(
								jahr, lastRest, zinsen, lastRest - rest, annunitaet
								));
							jahr++;
							lastRest = rest;
						}
					},
					   () => !double.IsNaN(Darlehen)
					   && !double.IsNaN(AnfaenglicheTilgung)
					   && !double.IsNaN(Zinssatz));

			InitialisierenCommand = new
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

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new(propertyName));
		}
		#endregion
	}
}
