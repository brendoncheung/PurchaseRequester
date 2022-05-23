// See https://aka.ms/new-console-template for more information
using PurchaseRequester.Application.Database;
using PurchaseRequester.Application.Requests.Commands;
using PurchaseRequester.Application.Requests.Queries;
using PurchaseRequester.Domain.Requests;
using PurchaseRequester.Persistence.Requests;
using PurchaseRequester.UI.Console.Requests.Repository;

IDatabaseService database = new RequestDbContext();
IGetAllRequestList getAllRequestList = new GetAllRequestList(database);
IAddRequest createARequest = new AddRequest(database);
IRemoveRequest removeARequest = new RemoveRequest(database);    
IUpdateRequest updateARequest = new UpdateRequest(database);

RequestRepository repo = new RequestRepository(
    createARequest, 
    getAllRequestList, 
    removeARequest,
    updateARequest
    );

Request request = new Request()
{
    PartNo = "123"
};

repo.AddARequest(request);

request.PartNo = "2345";

repo.UpdateRequest(request);

var list = repo.GetAllRequests().ToList();
Console.WriteLine("Items in db: ");
foreach (Request r in list)
{
    Console.WriteLine(r.PartNo);
}
