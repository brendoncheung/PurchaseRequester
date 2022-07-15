using PurchaseRequester.Domain.Requests;
using PurchaseRequester.UI.WPF.Common;
using PurchaseRequester.UI.WPF.Repository.Requests;
using System.Windows;

namespace PurchaseRequester.UI.WPF.Requests.AddRequests.ViewModel
{
    public class AddRequestViewModel : ViewModelBase
    {
        private readonly RequestRepository requestRepository;
        private Request request;
        private bool visibility;

        public AddRequestViewModel(RequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
            visibility = true; 
        }

        public bool Visibility
        {
            get => visibility; 
            set
            {
                visibility = value;
                RaisedPropertChanged();
            }
        }

        public Request Request
        {
            get
            {
                if(request is null)
                {
                    request = new Request();
                }
                return request;
            }
            set
            {
                showLoad();
                request = value;
                RaisedPropertChanged();
                hideLoad();
            }
        }

        public void Clear()
        {
            ClearForm();
        }

        public void AddRequest()
        {
            requestRepository.AddRequest(request);
            ClearForm();
        }

        private void showLoad()
        {
            visibility = true;
        }

        private void hideLoad()
        {
            visibility = false;
        }

        private void ClearForm()
        {
            Request = new Request();
        }
    }
}
