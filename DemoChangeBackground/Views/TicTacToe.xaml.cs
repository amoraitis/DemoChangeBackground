using System;
using DemoChangeBackground.Model;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Toolkit.Uwp.UI;

namespace DemoChangeBackground.Views
{
    public sealed partial class TicTacToe : Page
    {
        MyShape curent;
        public TicTacToe()
        {
            this.InitializeComponent();
            // Show UI in title bar if opted-in and in-app backstack is not empty.
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                AppViewBackButtonVisibility.Visible;
            var acv = new AdvancedCollectionView(new ViewModel.ApplyXO().GetContainer());
            TicTacContainer.ItemsSource = acv;
            SystemNavigationManager.GetForCurrentView().BackRequested += BackButton_Click;

        }      

        private void BackButton_Click(object sender, BackRequestedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                e.Handled = true;
                this.Frame.GoBack();
            }
        }       
        private void Items_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var myS =  (MyShape)TicTacContainer.SelectedItem;
            myS.Shape = Symbol.Clear;
            
        }        
       
    }
}
