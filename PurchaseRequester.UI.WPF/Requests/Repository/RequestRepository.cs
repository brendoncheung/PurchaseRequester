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
            return getAllRequest.Execute().ToList();
        }

        public List<Request> GetRequestsByStatus(params RequestStatus[] status)
        {
            return getAllRequest.Execute().Where((x) => status.Contains(x.Status)).ToList();
        }


        public void AddRequest(Request request)
        {
            addRequest.Execute(request);
        }
    }
}
