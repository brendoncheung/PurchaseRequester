using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Commands
{
    public interface IAddRequest
    {
        void Execute(Request request);
    }
}