using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Requests.Commands
{
    public interface IRemoveRequest
    {
        Request Execute(Request request);
    }
}