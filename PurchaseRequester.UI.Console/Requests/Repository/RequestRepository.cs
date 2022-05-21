using PurchaseRequester.Application.Requests.Commands;
using PurchaseRequester.Application.Requests.Queries;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.UI.Console.Requests.Repository
{
    public class RequestRepository
    {
        private readonly IAddRequest _addARequest;
        private readonly IGetAllRequestList _getAllRequests;
        private readonly IRemoveRequest removeRequest;

        public RequestRepository(IAddRequest createARequest, IGetAllRequestList getAllRequests, IRemoveRequest removeRequest)
        {
            _addARequest = createARequest;
            _getAllRequests = getAllRequests;
            this.removeRequest = removeRequest;
        }

        public List<Request> GetAllRequests()
        {
            return _getAllRequests.Execute().ToList();
        }

        public void AddARequest(Request request)
        {
            _addARequest.Execute(request);

        }

        public Request RemoveRequest(Request request)
        {
            return removeRequest.Execute(request);
        }
    }
}
