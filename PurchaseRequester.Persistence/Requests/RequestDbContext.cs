using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PurchaseRequester.Core.Database;
using PurchaseRequester.Domain.Requests;

namespace PurchaseRequester.Persistence.Requests
{
    public class RequestDbContext : DbContext, IDatabaseService
    {
        public DbSet<Request> Requests { get; set; }

        public RequestDbContext()
        {
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }

        public IEnumerable<Request> GetAllRequestList()
        {   
            return Requests;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=..\\database.db")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging()
                ;

            base.OnConfiguring(optionsBuilder);
        }

        public void AddRequest(Request request)
        {
            Requests.Add(request);
            this.SaveChanges();
        }


        public void RemoveRequest(Request request)
        {
            this.Remove(request);
            this.SaveChanges();
        }

        public void UpdateRequest(Request request)
        {
            this.Update(request);
            this.SaveChanges();
        }
    }
}
