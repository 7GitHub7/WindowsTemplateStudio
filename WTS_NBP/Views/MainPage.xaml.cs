using System;

using Windows.UI.Xaml.Controls;

using WTS_NBP.ViewModels;

namespace WTS_NBP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }
    }
}
