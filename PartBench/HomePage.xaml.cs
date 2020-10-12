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
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        #region Page Specific Nav
        private void btnVeiwBuildGuides_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BuildGuidePage));
        }

        private void btnBugetAmdGuide_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstBuild));
        }

        private void btnHighEndIntelGuide_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ThirdBuild));
        }

        private void btnVeiwBuilds_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BuildsPage));
        }

        private void btnBeginBuilding_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BuildEditorPage));
        }
        #endregion
    }
}
