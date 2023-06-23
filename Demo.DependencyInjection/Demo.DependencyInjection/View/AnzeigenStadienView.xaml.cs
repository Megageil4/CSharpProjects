// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Demo.DependencyInjection.Data;
using Demo.DependencyInjection.ViewModel;
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

namespace Demo.DependencyInjection.View
{
	public sealed partial class AnzeigenStadienView : UserControl
	{
		public AnzeigenStadienViewModel ViewModel { get; set; }
		public AnzeigenStadienView()
		{
			this.InitializeComponent();
		}
	}
}
