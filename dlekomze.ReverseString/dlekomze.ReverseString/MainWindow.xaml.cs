// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Text;
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
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace dlekomze.ReverseString
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

		private void OnEingabeUmkehren(object sender, RoutedEventArgs e)
		{
			string reversedText = "";
			for (int i = EingabeTextBox.Text.Length - 1; i >= 0; i--)
			{
				reversedText += EingabeTextBox.Text[i];
			}
			if (AusgabeoptionenRadionButtons.SelectedIndex == 1)
			{
				reversedText = reversedText.ToUpper();
			}
			if (AusgabeoptionenRadionButtons.SelectedIndex == 2)
			{
				reversedText = reversedText.ToLower();
			}
			if (VokaleEntfernenCheckBox.IsChecked.GetValueOrDefault())
			{
				reversedText = Regex.Replace(reversedText, "[aeiou]", "");
			}
			ErgebnisTextBlock.Text = reversedText;
		}

		private void OnFettdruck(object sender, RoutedEventArgs e)
		{
			if (((ToggleSwitch)sender).IsOn)
			{
				ErgebnisTextBlock.FontWeight = FontWeights.Bold;
			}
			else
			{
				ErgebnisTextBlock.FontWeight = FontWeights.Normal;
			}
		}
	}
}
