using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Queries
{
    public interface IGetAllRequestList
    {
        Task<List<Request>> Execute();
    }
}