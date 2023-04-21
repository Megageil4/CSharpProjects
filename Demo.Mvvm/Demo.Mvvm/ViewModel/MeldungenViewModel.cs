using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Mvvm.ViewModel
{
	public class MeldungenViewModel : INotifyPropertyChanged
	{
		private string _message;

		public string Message
		{
			get { return _message; }
			set 
			{
				if (_message != value)
				{
					_message = value;
					OnPropertyChanged();
					OnPropertyChanged(nameof(CanAddMessage));
				}
			}
		}

		public ObservableCollection<string> AllMessages { get; }

		public bool CanAddMessage => Message != string.Empty;
		public bool ContainesMessages => AllMessages.Count > 0;

		public MeldungenViewModel()
		{
			AllMessages = new();
			Message = string.Empty;
		}

		public void AddMessage()
		{
			AllMessages.Add(Message);
			Message = string.Empty;
			OnPropertyChanged(nameof(ContainesMessages));
		}

		public void DeleteAllMessages()
		{
			AllMessages.Clear();
			OnPropertyChanged(nameof(ContainesMessages));
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