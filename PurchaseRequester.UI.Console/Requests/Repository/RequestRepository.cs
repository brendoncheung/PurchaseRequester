using PurchaseRequester.Core.Requests.Commands;
using PurchaseRequester.Core.Requests.Queries;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.UI.Console.Requests.Repository
{
    public class RequestRepository
    {
        private readonly IAddRequest _addARequest;
        private readonly IGetAllRequestList _getAllRequests;
        private readonly IRemoveRequest removeRequest;

        public RequestRepository(IAddRequest createARequest, IGetAllRequestList getAllRequests, IRemoveRequest removeRequest, IUpdateRequest updateRequest)
        {
            _addARequest = createARequest;
            _getAllRequests = getAllRequests;
            this.removeRequest = removeRequest;
        }

        public async Task<List<Request>> GetAllRequests()
        {
            return await _getAllRequests.Execute();
        }

        public void AddARequest(Request request)
        {
            _addARequest.Execute(request);

        }

        public Task RemoveRequest(Request request)
        {
            return removeRequest.Execute(request);
        }

        public void UpdateRequest(Request request)
        {
            removeRequest.Execute(request);
        }
    }
}
