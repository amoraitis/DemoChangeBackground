using DemoChangeBackground.Model;
using System.Collections.ObjectModel;
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
            listView.ItemsSource = ViewModel.QuotaMenuItems.GetMenuItems();
        }
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            foreach (var item in rootFrame.BackStack.ToList())
                rootFrame.BackStack.Remove(item)
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
