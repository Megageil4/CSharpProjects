using CommunityToolkit.Mvvm.Input;
using dlekomze.TankenApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.TankenApp.ViewModel
{
	public class TankViewModel : INotifyPropertyChanged
	{
		private DateTimeOffset? _datum;
		private double _kilometerstand;
		private double _gefahreneKM;
		private double _preis;
		private double _getankteLiter;
		private bool _isInfoShowing;
		private string _infoMessage;

		public TankBelegDBContext TankBelegContext { get; set; }

		public DateTimeOffset? Datum 
		{
			get => _datum;
			set 
			{
				if (value != _datum)
				{
					_datum = value;
					OnPropertyChanged();
					DatenSpeichernCommand.NotifyCanExecuteChanged();
				}
			} 
		}
		public double Kilometerstand
		{
			get => _kilometerstand;
			set 
			{
				if (value != _kilometerstand)
				{
					_kilometerstand = value;
					OnPropertyChanged();
					DatenSpeichernCommand.NotifyCanExecuteChanged();
				}
			}
		}
		public double GefahreneKM 
		{
			get => _gefahreneKM;
			set
			{
				if (value != _gefahreneKM)
				{
					_gefahreneKM = value;
					OnPropertyChanged();
					DatenSpeichernCommand.NotifyCanExecuteChanged();
				}
			}
		}
		public double Preis 
		{ 
			get => _preis;
			set
			{
				if (value != _preis)
				{
					_preis = value;
					OnPropertyChanged();
					DatenSpeichernCommand.NotifyCanExecuteChanged();
				}
			}
		}
		public double GetankteLiter 
		{
			get => _getankteLiter;
			set
			{
				if (value != _getankteLiter)
				{
					_getankteLiter = value;
					OnPropertyChanged();
					DatenSpeichernCommand.NotifyCanExecuteChanged();
				}
			}
		}
		public RelayCommand DatenSpeichernCommand { get; set; }
		public bool IsInfoShowing 
		{
			get => _isInfoShowing;
			set
			{
				if (value != _isInfoShowing)
				{
					_isInfoShowing = value;
					OnPropertyChanged();
					DatenSpeichernCommand.NotifyCanExecuteChanged();
				}
			} 
		}
		public string InfoMessage 
		{
			get => _infoMessage;
			set
			{
				if (value != _infoMessage)
				{
					_infoMessage = value;
					OnPropertyChanged();
					DatenSpeichernCommand.NotifyCanExecuteChanged();
				}
			}
		}

		public TankViewModel()
		{
			TankBelegContext = new();
			DatenSpeichernCommand = new(
				() =>
					{
						//TankBelegContext.Add(new Tankbeleg(0,_datum.Value.DateTime,
						//					 Kilometerstand,GefahreneKM,Preis,GetankteLiter));
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
