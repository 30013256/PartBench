using Marduk.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class BuildGuidePage : Page
    {
        public BuildGuidePage()
        {
            this.InitializeComponent();
        }

        public string Header => "Build Guides";
        #region Page Specific Nav
        private void Btn_Click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FirstBuild));
        }

        private void Btn_Click2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SecondBuild));
        }

        private void Btn_Click3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ThirdBuild));
        }

        private void Btn_Click4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FourthBuild));
        }
        #endregion
    }
}
