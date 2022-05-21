using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.Application.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Requests.Commands
{
    public class RemoveRequest : IRemoveRequest
    {
        private readonly IDatabaseService databaseService;

        public RemoveRequest(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public Request Execute(Request request)
        {
            databaseService.RemoveRequest(request);
            return request;
        }
    }
}
