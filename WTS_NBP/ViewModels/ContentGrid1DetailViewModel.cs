using System;
using System.Linq;
using System.Threading.Tasks;

using Caliburn.Micro;

using WTS_NBP.Core.Models;
using WTS_NBP.Core.Services;
using WTS_NBP.Services;

namespace WTS_NBP.ViewModels
{
    public class ContentGrid1DetailViewModel : Screen
    {
        private readonly IConnectedAnimationService _connectedAnimationService;

        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public ContentGrid1DetailViewModel(IConnectedAnimationService connectedAnimationService)
        {
            _connectedAnimationService = connectedAnimationService;
        }

        public async Task InitializeAsync(long orderID)
        {
            // TODO WTS: Replace this with your actual data
            var data = await SampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }

        public void SetListDataItemForNextConnectedAnimation()
        {
            _connectedAnimationService.SetListDataItemForNextConnectedAnimation(Item);
        }
    }
}
