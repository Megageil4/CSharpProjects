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
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Demo.ChangeNotification.Pages
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class EinzelnesObjektPage : Page
	{
		Produkt Produkt { get; set; }
		public EinzelnesObjektPage()
		{
			this.InitializeComponent();
			Produkt = new Produkt { Bezeichnung = "Bohrmaschine", Nettopreis = 123.45 };
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Produkt.Nettopreis = Math.Round(Produkt.Nettopreis * 1.1, 2, MidpointRounding.AwayFromZero);
		}
	}
}
