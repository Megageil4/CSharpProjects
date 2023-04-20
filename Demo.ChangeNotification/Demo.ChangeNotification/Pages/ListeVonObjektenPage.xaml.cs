// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Demo.ChangeNotification.Model;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Portable;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Demo.ChangeNotification.Pages
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class ListeVonObjektenPage : Page
	{

		public ObservableCollection<Produkt> Produktliste { get; }
		public ListeVonObjektenPage()
		{
			this.InitializeComponent();
			Produktliste = new() {
				new Produkt () { Bezeichnung = "Kugelschreiber", Nettopreis = 0.79 },
				new Produkt () { Bezeichnung = "Notizblock", Nettopreis = 1.23 },
				new Produkt () { Bezeichnung = "Karteikarten", Nettopreis = 3.46 },
				new Produkt () { Bezeichnung = "Ordner", Nettopreis = 1.79 }
			};
		}

		private void HinzufuegenProdukt_Click(object sender, RoutedEventArgs e)
		{
			Produktliste.Add(new Produkt { Bezeichnung = "neues Produkt", Nettopreis = 100 });
		}

		private void LoeschenProdukt_Click(object sender, RoutedEventArgs e)
		{
			Produkt markiertesProdukt = ProdukteListView.SelectedItem as Produkt;
			if (markiertesProdukt != null)
			{
				Produktliste.Remove(markiertesProdukt);
			}
		}
	}
}
