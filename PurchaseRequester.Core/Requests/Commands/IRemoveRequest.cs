using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Commands
{
    public interface IRemoveRequest
    {
        Request Execute(Request request);
    }
}