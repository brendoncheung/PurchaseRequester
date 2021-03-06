using PurchaseRequester.Domain.Requests;
using PurchaseRequester.UI.WPF.Requests.ShowRequests.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace PurchaseRequester.UI.WPF.Requests.ShowRequests
{
    public partial class ShowAllRequestView : UserControl
    {
        public ShowAllRequestViewModel ViewModel { get; private set; }
       
        public ShowAllRequestView()
        {
            InitializeComponent();
            this.Loaded += ShowAllRequestView_Loaded;
        }

        public async void ShowRequests()
        {
            await ViewModel.ShowAllRequestByStatus(RequestStatus.PENDING, RequestStatus.NEW);
        }

        private void Refresh_Clicked(object sender, RoutedEventArgs e)
        {
            ShowRequests();
        }

        private void ShowAllRequestView_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel = (ShowAllRequestViewModel)DataContext;
        }

        private void Remove_Clicked(object sender, RoutedEventArgs e)
        {
            var request = selectedRequest();
            if(request != null)
            {
                ViewModel.RemoveRequest(request);
                ShowRequests();
            }
        }

        private Request selectedRequest()
        {
            return RequestGrid.dataGrid.SelectedItem as Request;
        }

        private void Save_Clicked(object sender, RoutedEventArgs e)
        {
            var request = selectedRequest();
            if(request != null)
            {
                ViewModel.UpdateRequest(request);
            }
        }
    }
}
