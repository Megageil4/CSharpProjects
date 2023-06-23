using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Demo.DependencyInjection.Data;
using Demo.DependencyInjection.Model;
using System;
using System.Collections.ObjectModel;

namespace Demo.DependencyInjection.ViewModel
{
	public class AnzeigenStadienViewModel : ObservableObject
	{

		private string _land;
		private IStadionReader _reader;

		public string Land
		{
			get { return _land; }
			set { SetProperty(ref _land, value); }
		}

		public ObservableCollection<Stadion> StadionListe { get; }

		public RelayCommand LadenCommand { get; }

		public AnzeigenStadienViewModel(IStadionReader reader)
		{
			LadenCommand = new(LadenExecute);
			Land = String.Empty;
			StadionListe = new();
			_reader = reader;
		}

		public void LadenExecute()
		{
			StadionListe.Clear();
			// CsvStadionReader reader = new();
			var stadien = _reader.LadenStadien(Land);
			foreach (var item in stadien)
			{
				StadionListe.Add(item);
			}
		}

	}
}

