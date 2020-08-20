using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PartBench
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BuildsPage : Page
    {
        public BuildsPage()
        {
            this.InitializeComponent();

            Window.Current.SetTitleBar(AppTitleBar);
        }

        #region Nav Items
        private void NavView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            if (this.Frame.CanGoBack == true)
            {
                this.Frame.GoBack();
            }
        }
        private void NavItemHome_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void NavItemTestPage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TestPage));
        }

        private void NavItemBuilds_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BuildsPage));
        }

        private void NavItemBuildGuidePage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BuildGuidePage));
        }
        #endregion

        #region Resize Content area on pane state
        private void NavView_PaneClosing(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewPaneClosingEventArgs args)
        {
            Thickness margin = ContentContainer.Margin;
            margin.Left = 90;
            ContentContainer.Margin = margin; 
        }

        private void NavView_PaneOpening(Microsoft.UI.Xaml.Controls.NavigationView sender, object args)
        {
            Thickness margin = ContentContainer.Margin;
            margin.Left = 330;
            ContentContainer.Margin = margin;
        }
        #endregion

        private void btnEditBuild_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BuildEditorPage));
        }
    }
}
