using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Commands
{
    public interface IRemoveRequest
    {
        void Execute(Request request);
    }
}