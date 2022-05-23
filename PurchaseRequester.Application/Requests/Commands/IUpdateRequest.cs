using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Requests.Commands
{
    public interface IUpdateRequest
    {
        void Execute(Request request);
    }
}