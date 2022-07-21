using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.Core.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Commands
{
    public class AddRequest : IAddRequest
    {
        private readonly IDatabaseService database;

        public AddRequest(IDatabaseService database)
        {
            this.database = database;
        }

        public void Execute(Request request)
        {
            database.AddRequestAsync(request);
        }
    }
}
