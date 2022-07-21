using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.Core.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Requests.Commands
{
    public class RemoveRequest : IRemoveRequest
    {
        private readonly IDatabaseService databaseService;

        public RemoveRequest(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public void Execute(Request request)
        {
            databaseService.RemoveRequestAsync(request);
            
        }
    }
}
