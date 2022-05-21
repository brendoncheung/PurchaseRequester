// See https://aka.ms/new-console-template for more information
using PurchaseRequester.Application.Database;
using PurchaseRequester.Application.Requests.Commands;
using PurchaseRequester.Application.Requests.Queries;
using PurchaseRequester.Domain.Requests;
using PurchaseRequester.Persistence.Requests;
using PurchaseRequester.UI.Console.Requests.Repository;

Console.WriteLine("Hello, World!");

IDatabaseService database = new RequestDbContext();


IGetAllRequestList getAllRequestList = new GetAllRequestList(database);
IAddARequest createARequest = new AddARequest(database);

RequestRepository repo = new RequestRepository(createARequest, getAllRequestList);

repo.AddARequest(new Request
{
    PartNo = "123"
});

Console.WriteLine("Items in db: ");
foreach (Request r in repo.GetAllRequests())
{
    Console.WriteLine(r.PartNo);
}
