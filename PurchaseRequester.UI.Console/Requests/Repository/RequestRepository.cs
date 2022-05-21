using PurchaseRequester.Application.Requests.Commands;
using PurchaseRequester.Application.Requests.Queries;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.UI.Console.Requests.Repository
{
    public class RequestRepository
    {
        private readonly IAddARequest _addARequest;
        private readonly IGetAllRequestList _getAllRequests;

        public RequestRepository(IAddARequest createARequest, IGetAllRequestList getAllRequests)
        {
            _addARequest = createARequest;
            _getAllRequests = getAllRequests;
        }

        public List<Request> GetAllRequests()
        {
            return _getAllRequests.Execute().ToList();
        }

        public void AddARequest(Request request)
        {
            _addARequest.Execute(request);

        }
    }
}
