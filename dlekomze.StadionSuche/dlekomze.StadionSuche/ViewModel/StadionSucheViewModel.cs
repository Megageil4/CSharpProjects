using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using dlekomze.StadionSuche.Data;
using dlekomze.StadionSuche.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.StadionSuche.ViewModel
{
    public class StadionSucheViewModel : ObservableObject
	{
		public ObservableCollection<Stadion> StadionList { get; }
		public AsyncRelayCommand LadenCommand{ get; set; }
		public StadionSucheViewModel()
		{
			StadionList = new();
			LadenCommand = new(Laden,CanLaden);
		}
		public async Task Laden()
		{
			StadionList.Clear();
			CsvReader reader = new(AppContext.BaseDirectory);
			var stadien = await reader.LadenStadien();
			foreach (var stadion in stadien)
			{
				StadionList.Add(stadion);
			}
		}

		public bool CanLaden()
		{
			return true;
		}
	}
}
