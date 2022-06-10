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

        public List<Catagory> Catagories = new() { 
            Catagory.TOOLING, 
            Catagory.MISC, 
            Catagory.PASSTHOUGH};

        public AddRequestViewModel(RequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
        }
    }
}
