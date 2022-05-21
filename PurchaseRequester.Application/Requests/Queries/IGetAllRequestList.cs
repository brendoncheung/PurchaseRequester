using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Requests.Queries
{
    public interface IGetAllRequestList
    {
        IEnumerable<Request> Execute();
    }
}