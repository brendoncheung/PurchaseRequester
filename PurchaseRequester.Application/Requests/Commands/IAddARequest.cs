using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Requests.Commands
{
    public interface IAddARequest
    {
        void Execute(Request request);
    }
}