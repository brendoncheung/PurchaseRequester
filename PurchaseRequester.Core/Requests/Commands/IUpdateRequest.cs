using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Commands
{
    public interface IUpdateRequest
    {
        void Execute(Request request);
    }
}