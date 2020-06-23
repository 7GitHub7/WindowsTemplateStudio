using System;
using System.Threading.Tasks;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using WTS_NBP.ViewModels;

namespace WTS_NBP.Views
{
    public sealed partial class ContentGrid1Page : Page
    {
        public ContentGrid1Page()
        {
            InitializeComponent();
        }

        private ContentGrid1ViewModel ViewModel
        {
            get { return DataContext as ContentGrid1ViewModel; }
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
