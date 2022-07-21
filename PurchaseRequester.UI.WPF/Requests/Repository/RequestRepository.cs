using PurchaseRequester.Core.Requests.Commands;
using PurchaseRequester.Core.Requests.Queries;
using PurchaseRequester.Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PurchaseRequester.UI.WPF.Repository.Requests
{
    public class RequestRepository
    {
        private readonly IGetAllRequestList getAllRequest;
        private readonly IAddRequest addRequest;
        private readonly IRemoveRequest removeRequest;

        public RequestRepository(
            IGetAllRequestList getAllRequest, 
            IAddRequest addRequest, 
            IRemoveRequest removeRequest)
        {
            this.getAllRequest = getAllRequest;
            this.addRequest = addRequest;
            this.removeRequest = removeRequest;
        }

        public async Task<List<Request>> GetRequests()
        {
            var results = await getAllRequest.Execute();
            return results;
        }

        public async Task<List<Request>> GetRequestsByStatus(params RequestStatus[] status)
        {
            var results = await getAllRequest.Execute();
            return results.Where((x) => status.Contains(x.Status)).ToList();
        }

        public void RemoveRequest(Request request)
        {
            removeRequest.Execute(request);
        }

        public void AddRequest(Request request)
        {
            addRequest.Execute(request);
        }
    }
}
