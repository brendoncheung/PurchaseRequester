using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Requests.Commands
{
    public interface IAddRequest
    {
        void Execute(Request request);
    }
}