// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

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

namespace dlekomze.TextToString
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
		}

		private void OnUmwandeln(object sender, RoutedEventArgs e)
		{
			string varname = VariableTextBox.Text;
			string output = $"string {varname} = String.Empty;{Environment.NewLine}";
			foreach (var s in EingabeTextBox.Text.Split("\r"))
			{
				output += $"{varname} += \"{s}\";{Environment.NewLine}";
			}
			AusgabeTextBox.Text = output;
        }

		private void InputTextChanged(object sender, TextChangedEventArgs e)
		{
			UmwandelnButton.IsEnabled = false;
			if (EingabeTextBox.Text != "" && VariableTextBox.Text != "")
			{
				UmwandelnButton.IsEnabled = true;
			}
		}
	}
}
