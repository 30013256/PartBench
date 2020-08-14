using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace PartBench
{
    public sealed partial class SplashScreen : Page
    {
        public SplashScreen()
        {   
            ApplicationView.PreferredLaunchViewSize = new Size(Width = 1280, Height = 720);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            
            this.InitializeComponent();

            Redirect();
            LogoFade();      
        }

        private async void Redirect()
        {
            await Task.Delay(3400);
            this.Frame.Navigate(typeof(MainPage));

            //Stops Back Button on main page loading Splash Screen again
            var frame = Window.Current.Content as Frame;
            frame.BackStack.Clear();
        }

        private async void LogoFade()
        {
            for (int i = 0; i < 3000; i++)
            {
                await Task.Delay(50);
                _2ndlogo.Opacity += 0.03;
            }
        }     
    }
}
