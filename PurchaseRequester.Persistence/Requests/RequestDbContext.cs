using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Npgsql;
using PurchaseRequester.Core.Database;
using PurchaseRequester.Domain.Requests;
using System.Configuration;

namespace PurchaseRequester.Persistence.Requests
{
    public class RequestDbContext : DbContext, IDatabaseService
    {
        public DbSet<Request> Requests { get; set; }

        static RequestDbContext()
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<RequestCatagory>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<RequestStatus>();
            
        }

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

            //var cs = ConfigurationManager.ConnectionStrings["OBDC"].ConnectionString;
            //"User Id=postgres;Password=Wingsuncheung2609;Server=db.pidijpusjwzlhrkpcodl.supabase.co;Port=5432;Database=postgres"

            optionsBuilder.
                UseNpgsql("User Id=postgres;Password=Wingsuncheung2609;Server=db.pidijpusjwzlhrkpcodl.supabase.co;Port=5432;Database=postgres");
            //optionsBuilder.UseSqlite(
            //    "Data Source=..\\database.db")
            //    .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
            //    .EnableSensitiveDataLogging()
            //    ;

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<RequestCatagory>();
            modelBuilder.HasPostgresEnum<RequestStatus>();
            modelBuilder.Entity<Request>().Property(r => r.Catagory).HasConversion<string>();
            modelBuilder.Entity<Request>().Property(r => r.Status).HasConversion<string>();
            base.OnModelCreating(modelBuilder);
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
