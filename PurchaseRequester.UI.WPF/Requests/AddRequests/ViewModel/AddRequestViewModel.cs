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
        public Request Request
        {
            get => Request is null? new Request() : Request;
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

        public void AddRequest(Request request)
        {
            requestRepository.AddRequest(new Request { PartNo="123"});
        }

        public void Add(object? parameter)
        {

        }
    }
}
