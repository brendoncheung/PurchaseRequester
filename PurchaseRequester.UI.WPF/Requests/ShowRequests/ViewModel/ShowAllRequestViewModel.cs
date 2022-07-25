using PurchaseRequester.Domain.Requests;
using PurchaseRequester.UI.WPF.Common;
using PurchaseRequester.UI.WPF.Repository.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequester.UI.WPF.Requests.ShowRequests.ViewModel
{
    public class ShowAllRequestViewModel : ViewModelBase
    {
        public RequestRepository RequestRepository { get; }

        private ObservableCollection<Request> _requests = new();
        public ObservableCollection<Request> Requests
        {
            get => _requests;
            set
            {
                _requests = value;
                RaisedPropertChanged();
            }
        }

        public ShowAllRequestViewModel(RequestRepository requestRepository)
        {
            RequestRepository = requestRepository;
        }

        public async Task ShowAllRequestByStatus(params RequestStatus[] status)
        {
            Requests.Clear();
            var results = await RequestRepository.GetRequestsByStatus(status);
            Requests = new ObservableCollection<Request>(results);
        }

        public async void ShowAllRequest()
        {
            Requests.Clear();
            var results = await RequestRepository.GetRequests();
            Requests = new ObservableCollection<Request>(results);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void RemoveRequest(Request request)
        {
            RequestRepository.RemoveRequest(request);
        }
    }
}
