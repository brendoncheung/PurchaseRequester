using PurchaseRequester.Application.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Requests.Queries
{
    public class GetAllRequestList : IGetAllRequestList
    {
        private readonly IDatabaseService database;

        public GetAllRequestList(IDatabaseService database)
        {
            this.database = database;
        }

        public IEnumerable<Request> Execute()
        {
            return database.GetAllRequestList();
        }
    }
}
