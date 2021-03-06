using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.Core.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Commands
{
    public class UpdateRequest : IUpdateRequest
    {
        private readonly IDatabaseService Database;

        public UpdateRequest(IDatabaseService databaseService)
        {
            this.Database = databaseService;
        }

        public void Execute(Request request)
        {
            Database.UpdateRequestAsync(request);
        }

    }
}
