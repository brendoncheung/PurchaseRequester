using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.Domain.Requests;
using PurchaseRequester.UI.WPF.Common;
using PurchaseRequester.UI.WPF.Repository.Requests;

namespace PurchaseRequester.UI.WPF.Requests.AddRequests.ViewModel
{
    public class AddRequestViewModel : ViewModelBase
    {
        private readonly RequestRepository requestRepository;

        private Request _request;

        public Request Request
        {
            get
            {
                if(_request is null)
                {
                    _request = new Request();
                }
                return _request;
 
            }
            set
            {
                RaisedPropertChanged();
            }
        }

        public DelegateCommand AddCommand { get; }

        public AddRequestViewModel(RequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
            AddCommand = new DelegateCommand(Add);
        }

        public void AddRequest()
        {
            requestRepository.AddRequest(_request);
        }

        public void Add(object? parameter)
        {

        }
    }
}
