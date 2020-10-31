using PartBench.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class ForumsPage : Page
    {
        public List<Forums> Forum;
        public List<Forums> Forum2;
        public List<Forums> Forum3;
        public List<Forums> Forum4;

        public ForumsPage()
        {
            this.InitializeComponent();
            Forum = ForumManager.GetForums();
            Forum2 = ForumManager.GetForums2();
            Forum3 = ForumManager.GetForums3();
            Forum4 = ForumManager.GetForums4();
        }
        public string Header => "Forums";     
    }
}
