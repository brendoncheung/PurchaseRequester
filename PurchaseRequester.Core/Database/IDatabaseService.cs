using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Core.Database
{
    public interface IDatabaseService
    {
        // Queries
        public Task<List<Request>> GetAllRequestList();

        // Commands
        public void AddRequestAsync(Request request);
        public void RemoveRequestAsync(Request request);
        public void UpdateRequestAsync(Request request);
    }
}
