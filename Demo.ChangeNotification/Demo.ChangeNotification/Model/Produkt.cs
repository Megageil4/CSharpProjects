using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ChangeNotification.Model
{
#nullable enable
	public class Produkt : INotifyPropertyChanged
	{
		private string _bezeichnung;
		private double _nettopreis;

		public string Bezeichnung
		{
			get => _bezeichnung;
			set
			{
				if (_bezeichnung != value)
				{
					_bezeichnung = value;
					OnPropertyChanged();
				}
			}
		}
		public double Nettopreis 
		{ 
			get => _nettopreis;
			set
			{
				if (_nettopreis != value)
				{
					_nettopreis = value;
					OnPropertyChanged();
					OnPropertyChanged(nameof(Bruttopreis));
				}
			}
		}
		public double Bruttopreis => Math.Round(Nettopreis * 1.19, 2, MidpointRounding.AwayFromZero);

		public event PropertyChangedEventHandler? PropertyChanged;

		public Produkt()
		{
			Bezeichnung = string.Empty;
			_bezeichnung = Bezeichnung;
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
