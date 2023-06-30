using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uebung.TankenApp.Entity;
using Uebung.TankenApp.SqlServer;

namespace Uebung.TankenApp.ViewModel
{
	public class ErfassenTankbelegViewModel : ObservableObject
	{
		private DateTimeOffset _datum;

		public DateTimeOffset Datum
		{
			get { return _datum; }
			set
			{
				if (SetProperty(ref _datum, value))
					IsOpen = false;
			}
		}

		private int _kilometerstand;

		public int Kilometerstand
		{
			get { return _kilometerstand; }
			set
			{
				if (SetProperty(ref _kilometerstand, value))
					IsOpen = false;
			}
		}

		private double _gefahreneKM;

		public double GefahreneKM
		{
			get { return _gefahreneKM; }
			set
			{
				if (SetProperty(ref _gefahreneKM, value))
				{
					OnPropertyChanged(nameof(Durchschnitt));
					OnPropertyChanged(nameof(Meldung));
					IsOpen = false;
				}

			}
		}

		private double _preis;

		public double Preis
		{
			get { return _preis; }
			set
			{
				if (SetProperty(ref _preis, value))
					IsOpen = false;
			}
		}

		private double _getankteLiter;

		public double GetankteLiter
		{
			get { return _getankteLiter; }
			set
			{
				if (SetProperty(ref _getankteLiter, value))
				{
					OnPropertyChanged(nameof(Durchschnitt));
					OnPropertyChanged(nameof(Meldung));
					IsOpen = false;
				}
			}
		}



		public double Durchschnitt => Math.Round(GetankteLiter * 100 / GefahreneKM, 2);
		public string Meldung => $"Der Durchschnittsverbrauch lag bei {Durchschnitt} Liter/100 km";
		private bool _isOpen;

		public bool IsOpen
		{
			get { return _isOpen; }
			set { SetProperty(ref _isOpen, value); }
		}

		public AsyncRelayCommand SpeichernCommand { get; }

		private ITankenRepository tankenRepository;

		public ErfassenTankbelegViewModel(ITankenRepository tankenRepository)
		{
			this.tankenRepository = tankenRepository;
			SpeichernCommand = new(Speichern);
			// Vorbelegung mit Beispieldaten. Nur zum einfachern Testen.
			// Nicht in Produktiv-Anwendung!
			IsOpen = false;
			VorbelegenEingabefelder(23456, 635.7, 69.28, DateTimeOffset.Now, 49.12);
		}

		public async Task Speichern()
		{
			await tankenRepository.Speichern(ErstellenTankvorgangEntity());
			IsOpen = true;

		}

		private void VorbelegenEingabefelder(int kilometerstand, double gefahreneKM, double preis, DateTimeOffset datum, double getankteLiter)
		{
			Kilometerstand = kilometerstand;
			GefahreneKM = gefahreneKM;
			Preis = preis;
			Datum = datum;
			GetankteLiter = getankteLiter;
		}

		private Tankvorgang ErstellenTankvorgangEntity()
		{
			Tankvorgang neuerTankvorgang = new();
			neuerTankvorgang.Datum = Datum;
			neuerTankvorgang.Kilometerstand = Kilometerstand;
			neuerTankvorgang.GefahreneKilometer = GefahreneKM;
			neuerTankvorgang.Preis = (decimal)Preis;
			neuerTankvorgang.GetankteLiter = GetankteLiter;
			return neuerTankvorgang;
		}
	}
}
