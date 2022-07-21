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

        public Task<List<Request>> GetAllRequestList()
        {   
            return Requests.ToListAsync();
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

        public async void AddRequestAsync(Request request)
        {
            Requests.Add(request);
            await this.SaveChangesAsync();
        }

        public async void RemoveRequestAsync(Request request)
        {
            this.Remove(request);
            await this.SaveChangesAsync();
        }

        public async void UpdateRequestAsync(Request request)
        {
            this.Update(request);
            await this.SaveChangesAsync();
        }
    }
}
