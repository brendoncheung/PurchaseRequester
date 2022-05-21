using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Application.Database
{
    public interface IDatabaseService
    {
        // Queries
        public IEnumerable<Request> GetAllRequestList();

        // Commands
        public void AddARequest(Request request);
    }
}
