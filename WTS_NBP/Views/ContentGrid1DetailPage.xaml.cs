using System;

using Microsoft.Toolkit.Uwp.UI.Animations;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using WTS_NBP.Core.Models;
using WTS_NBP.ViewModels;

namespace WTS_NBP.Views
{
    public sealed partial class ContentGrid1DetailPage : Page
    {
        public ContentGrid1DetailPage()
        {
            InitializeComponent();
        }

        private ContentGrid1DetailViewModel ViewModel
        {
            get { return DataContext as ContentGrid1DetailViewModel; }
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.RegisterElementForConnectedAnimation("animationKeyContentGrid1", itemHero);
            if (e.Parameter is long orderID)
            {
                await ViewModel.InitializeAsync(orderID);
            }
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            if (e.NavigationMode == NavigationMode.Back)
            {
                ViewModel.SetListDataItemForNextConnectedAnimation();
            }
        }
    }
}
