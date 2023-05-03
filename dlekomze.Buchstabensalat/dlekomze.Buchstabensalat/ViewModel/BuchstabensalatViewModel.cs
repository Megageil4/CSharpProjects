using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Buchstabensalat.ViewModel
{
	public class BuchstabensalatViewModel : INotifyPropertyChanged
	{
		private string _eingabe;

		public string Eingabe
		{
			get { return _eingabe; }
			set 
			{ 
				_eingabe = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(CanWortMischen));
			}
		}

		private string _ausgabe;

		public string Ausgabe
		{
			get { return _ausgabe; }
			private set 
			{ 
				_ausgabe = value;
				OnPropertyChanged();
			}
		}


		public bool CanWortMischen => Eingabe.Length >= 3 
								   && Eingabe.Length <= 30;

		public BuchstabensalatViewModel()
		{
			Eingabe = "Regenbogen";
		}

		public void WortMischen()
		{
			Random rng = new();
			Ausgabe = new string(Eingabe.ToCharArray()
								 .OrderBy(x => rng.Next())
								 .ToArray());
		}

		#region PropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}
