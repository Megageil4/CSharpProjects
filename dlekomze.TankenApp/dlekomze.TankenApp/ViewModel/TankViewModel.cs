using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.TankenApp.ViewModel
{
	public class TankViewModel
	{
		private DateTimeOffset? datum;
		private double kilometerstand;
		private double gefahreneKM;
		private double preis;
		private double getankteLiter;
		private bool isInfoShowing;
		private string infoMessage;

		public TankBelegDBContext TankBelegContext { get; set; }

		public DateTimeOffset? Datum 
		{
			get => datum;
			set 
			{
				OnPropertyChanged();
				datum = value; 
			} 
		}
		public double Kilometerstand
		{
			get => kilometerstand;
			set 
			{
				OnPropertyChanged();
				kilometerstand = value; 
			}
		}
		public double GefahreneKM 
		{
			get => gefahreneKM;
			set
			{
				OnPropertyChanged();
				gefahreneKM = value;
			}
		}
		public double Preis 
		{ 
			get => preis;
			set
			{
				OnPropertyChanged();
				preis = value;
			}
		}
		public double GetankteLiter 
		{
			get => getankteLiter;
			set
			{
				OnPropertyChanged();
				getankteLiter = value;
			}
		}
		public RelayCommand DatenSpeichernCommand { get; set; }
		public bool IsInfoShowing 
		{
			get => isInfoShowing;
			set
			{
				OnPropertyChanged();
				isInfoShowing = value;
			} 
		}
		public string InfoMessage 
		{
			get => infoMessage;
			set
			{
				OnPropertyChanged();
				infoMessage = value;
			}
		}

		public TankViewModel()
		{
			TankBelegContext = new();
			DatenSpeichernCommand = new(
				() =>
					{
						InfoMessage = $"Der Durchschnittsverbrauch lag bei {GefahreneKM} Liter/100 km";
						IsInfoShowing = true;
					},
				() => Kilometerstand > 0
					  && GefahreneKM > 0
					  && Preis > 0
					  && GetankteLiter > 0
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
