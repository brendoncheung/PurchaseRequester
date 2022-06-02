using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Queries
{
    public interface IGetAllRequestList
    {
        IEnumerable<Request> Execute();
    }
}