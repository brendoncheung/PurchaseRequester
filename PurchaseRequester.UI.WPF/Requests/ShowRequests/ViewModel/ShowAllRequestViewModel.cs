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
            foreach (Request r in results)
            {
                Requests.Add(r);
            }
            RaisedPropertChanged(nameof(Requests));
        }

        public async void ShowAllRequest()
        {
            var results = await RequestRepository.GetRequests();
            Requests.Clear();
            foreach (Request r in results)
            {
                Requests.Add(r);
            }

            RaisedPropertChanged(nameof(Requests));
        }

        public void RemoveRequest(Request request)
        {
            RequestRepository.RemoveRequest(request);
        }

        private async Task<List<Request>> GetAllRequest(Func<Request, bool> filter)
        {
            Requests.Clear();
            var results = await RequestRepository.GetRequests();
            foreach (Request r in results)
            {
                if(filter(r))
                {
                    Requests.Add(r);
                }
            }
            return await RequestRepository.GetRequests();
        }
    }
}
