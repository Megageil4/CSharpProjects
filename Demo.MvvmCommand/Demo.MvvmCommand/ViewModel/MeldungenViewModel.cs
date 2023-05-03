using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Linq;
using Demo.MvvmCommand.MvvmHelper;

namespace Demo.Mvvm.ViewModel;

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
				AddMessageCommand.NotifyCanExecuteChanged();
				
			}
		}
	}
	public ObservableCollection<string> AllMessages { get; }

	public RelayCommand AddMessageCommand { get; }
	public RelayCommand DeleteAllMessageCommand { get; }

	public MeldungenViewModel()
	{
		AddMessageCommand = new(() =>
		{
			AllMessages.Add(Message);
			DeleteAllMessageCommand.NotifyCanExecuteChanged();
		},
		() => Message != string.Empty);

		DeleteAllMessageCommand = new(() =>
		{
			AllMessages.Clear();
			DeleteAllMessageCommand.NotifyCanExecuteChanged();
		},
		() => AllMessages.Count != 0);

		Message = String.Empty;
		AllMessages = new();
	}

	#region INotifyPropertyChanged
	public event PropertyChangedEventHandler PropertyChanged;
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChanged?.Invoke(this, new(propertyName));
	}
	#endregion
}

