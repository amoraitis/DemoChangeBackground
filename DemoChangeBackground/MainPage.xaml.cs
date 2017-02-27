using DemoChangeBackground.Model;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DemoChangeBackground
{
    public sealed partial class MainPage : Page
    {
        MenuItem myItem;
        public MainPage()
        {
            this.InitializeComponent();
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                Windows.UI.Core.AppViewBackButtonVisibility.Collapsed;
            listView.ItemsSource = ViewModel.QuotaMenuItems.GetMenuItems();            
        }        
        private void ItemsControl_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            setItem();            
            ((Frame)Window.Current.Content).Navigate(myItem.Page);
        }
        private void setItem()
        {
            myItem = (MenuItem)listView.SelectedItem;
        }

       
    }
}
