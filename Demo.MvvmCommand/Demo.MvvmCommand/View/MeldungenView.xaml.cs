// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Demo.Mvvm.ViewModel;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Demo.MvvmCommand.View
{
	public sealed partial class MeldungenView : UserControl
	{
		public MeldungenViewModel ViewModel { get; }
		public MeldungenView()
		{
			this.InitializeComponent();
			this.ViewModel = new();
		}
	}
}
