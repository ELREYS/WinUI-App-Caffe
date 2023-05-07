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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using WiredBrainCoffee.Data;
using WiredBrainCoffee.ViewModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WiredBrainCoffee
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Title = "Customers App";
            ViewModel = new MainViewModel(new CustomerDataProvider());
            root.DataContext = ViewModel;
            root.Loaded += Root_Loaded;
        }

        public MainViewModel ViewModel { get; }
        private async void Root_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadAsync();
        }

        

        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            //var column = (int)customerListGrid.GetValue(Grid.ColumnProperty);
            var column = Grid.GetColumn(customerListGrid);

            var newColumn = column == 0 ? 2 : 0; 
            Grid.SetColumn(customerListGrid, newColumn);
            //customerListGrid.SetValue(Grid.ColumnProperty, newColumn);
            SymbolIconNavigation.Symbol = newColumn == 0 ? Symbol.Forward : Symbol.Back;
        }

        
    }
}
