using Microsoft.EntityFrameworkCore;
using PurchaseRequester.Application.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Persistence.Requests
{
    public class RequestDbContext : DbContext, IDatabaseService
    {
        public DbSet<Request> Requests { get; set; }

        public void AddARequest(Request request)
        {
            Requests.Add(request);
            this.SaveChanges();
        }

        public RequestDbContext()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }

        public IEnumerable<Request> GetAllRequestList()
        {
            return Requests;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.\\testing.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
