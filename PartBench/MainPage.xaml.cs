using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;


namespace PartBench
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

            // Set XAML element as a draggable region.
            Window.Current.SetTitleBar(AppTitleBar);
     
            //Changes Title bar colors
            ApplicationView view = ApplicationView.GetForCurrentView();
            ApplicationViewTitleBar titleBar = view.TitleBar;
            titleBar.ForegroundColor = Windows.UI.Color.FromArgb(255, 0, 0, 255);
            titleBar.ButtonBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonHoverBackgroundColor = Windows.UI.Color.FromArgb(20, 255, 255, 255);
            titleBar.ButtonPressedBackgroundColor = Windows.UI.Color.FromArgb(50, 255, 255, 255);
            titleBar.ButtonInactiveBackgroundColor = Windows.UI.Color.FromArgb(0, 255, 255, 255);

            ContentContainer.Navigate(typeof(HomePage));

            sel();
        }

        public async void sel()
        {
            await Task.Delay(10);
            NavItemHome.IsSelected = true;   
        }

        

        #region Nav Items
        private void NavView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            if (ContentContainer.CanGoBack == true)
            {
                ContentContainer.GoBack();
            }
        }
        private void NavItemHome_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentContainer.Navigate(typeof(HomePage));
        }

        private void NavItemFAQPage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentContainer.Navigate(typeof(FAQPage));
            
        }

        private void NavItemBuilds_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentContainer.Navigate(typeof(BuildsPage), null, new SuppressNavigationTransitionInfo());
        }

        private void NavItemBuildGuidePage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentContainer.Navigate(typeof(BuildGuidePage));
        }
        
        private void NavItemForumsPage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentContainer.Navigate(typeof(ForumsPage));
        }

        private void NavItemPricePerformance_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentContainer.Navigate(typeof(PricePerformancePage));
        }

        private void NavItemBenchmark_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentContainer.Navigate(typeof(BenchmarkPage));
        }
        #endregion

    }
}
