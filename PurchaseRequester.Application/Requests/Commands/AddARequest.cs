using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.Application.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Requests.Commands
{
    public class AddARequest : IAddARequest
    {
        private readonly IDatabaseService database;

        public AddARequest(IDatabaseService database)
        {
            this.database = database;
        }

        public void Execute(Request request)
        {
            database.AddARequest(request);
        }

    }
}
