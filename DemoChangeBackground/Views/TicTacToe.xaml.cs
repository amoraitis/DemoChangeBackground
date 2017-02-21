using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DemoChangeBackground.Views
{
    public sealed partial class TicTacToe : Page
    {
        public TicTacToe()
        {
            this.InitializeComponent();
            TicTacContainer.ItemsSource = (new ViewModel.ApplyXO()).GetContainer();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }
    }
}
