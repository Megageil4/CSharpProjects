using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DependencyInjection.ViewModel
{
	public class MainViewModel : ObservableObject
	{
		public AnzeigenStadienViewModel AnzeigenStadienViewModel { get; }

		public MainViewModel(AnzeigenStadienViewModel anzeigenStadienViewModel)
		{
			AnzeigenStadienViewModel = anzeigenStadienViewModel;
		}
	}
}
