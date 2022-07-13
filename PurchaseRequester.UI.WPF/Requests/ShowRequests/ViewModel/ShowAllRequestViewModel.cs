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

        public List<Request> GetAllRequestByStatus(params RequestStatus[] status)
        {
            return GetAllRequest((x) => status.Contains(x.Status));
        }

        public List<Request> GetAllRequest()
        {
            return GetAllRequest((x) => true);
        }

        private List<Request> GetAllRequest(Func<Request, bool> filter)
        {
            Requests.Clear();
            foreach(Request r in RequestRepository.GetRequests())
            {
                if(filter(r))
                {
                    Requests.Add(r);
                }
            }

            RaisedPropertChanged(nameof(Requests));

            return RequestRepository.GetRequests().ToList();
        }
    }
}
