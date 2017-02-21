using DemoChangeBackground.Model;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DemoChangeBackground
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            listView.ItemsSource = ViewModel.QuotaMenuItems.GetMenuItems();
        }

        private void listView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var handlemenu = e.ClickedItem as MenuItem;
            MenuItem handleMenuClick = (MenuItem)listView.SelectedItem;
            //((Frame)Window.Current.Content).Navigate(handleMenuClick.Page);
            Application.Current.Exit();
            //TODO: Fix listview_ItemClick to work!
        }
    }
}
