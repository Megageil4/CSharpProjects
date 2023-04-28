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
			}
		}

		private string _ausgabe;

		public string Ausgabe
		{
			get { return _ausgabe; }
			private set { _ausgabe = value; }
		}


		public bool CanWortMischen => Eingabe.Length >= 3 
								   && Eingabe.Length <= 30;

		public void WortMischen()
		{

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
