using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace DemoChangeBackground.Views
{    
    public sealed partial class ChangeBackground : Page
    {
        private DispatcherTimer timer;
        DateTime now;
        DateTime clicked;
        public ChangeBackground()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //Documentation:https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.dispatchertimer
            timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 1) };
            timer.Start();
            //Sample:https://github.com/Microsoft/Windows-universal-samples/blob/master/Samples/Accelerometer/cs/Scenario3_Polling.xaml.cs
            timer.Tick += onStop;
        }
        private void onStop(object sender, object e)
        {            
            ((DispatcherTimer)sender).Stop();
            MyRespond.IsEnabled = true;
            MyRespond.Visibility = Visibility.Visible;
            now = DateTime.Now;
        }

        private void MyRespond_Click(object sender, RoutedEventArgs e)
        {
            clicked = DateTime.Now;
            MainGrid.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            var sum = clicked - now;
            Information.Text = "You did "+sum.TotalSeconds.ToString()+" seconds to respond";
        }
    }
}
