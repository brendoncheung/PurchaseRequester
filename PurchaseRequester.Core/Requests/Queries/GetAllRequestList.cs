using PurchaseRequester.Core.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Queries
{
    public class GetAllRequestList : IGetAllRequestList
    {
        private readonly IDatabaseService database;

        public GetAllRequestList(IDatabaseService database)
        {
            this.database = database;
        }

        public Task<List<Request>> Execute()
        {
            return database.GetAllRequestList();
        }
    }
}
