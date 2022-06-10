using PurchaseRequester.Core.Requests.Commands;
using PurchaseRequester.Core.Requests.Queries;
using PurchaseRequester.Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequester.UI.WPF.Repository.Requests
{
    public class RequestRepository
    {
        private readonly IGetAllRequestList getAllRequest;
        private readonly IAddRequest addRequest;

        public RequestRepository(IGetAllRequestList getAllRequest, IAddRequest addRequest)
        {
            this.getAllRequest = getAllRequest;
            this.addRequest = addRequest;
        }

        public List<Request> GetRequests()
        {
            var requests = new List<Request>();
            requests.Add(new Request());
            requests.Add(new Request());
            requests.Add(new Request());
            requests.Add(new Request());
            return requests;


        }

        public void AddRequest(Request request)
        {
            addRequest.Execute(request);
        }
    }
}
