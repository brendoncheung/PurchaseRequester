using PurchaseRequester.Domain.Requests;
using PurchaseRequester.UI.WPF.Common;
using PurchaseRequester.UI.WPF.Repository.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequester.UI.WPF.Requests.HistoryRequests.ViewModel
{
    public class HistoryRequestViewModel : ViewModelBase
    {
        private readonly RequestRepository requestRepository;

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

        public HistoryRequestViewModel(RequestRepository repository)
        {
            this.requestRepository = repository;
        }

        public void ShowAllCompletedRequests()
        {
            Requests.Clear();
            foreach (Request r in requestRepository.GetRequestsByStatus(RequestStatus.COMPLETED))
            {
                Requests.Add(r);
            }

            RaisedPropertChanged(nameof(Requests));
            
        }
     }
}
