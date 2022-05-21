﻿// See https://aka.ms/new-console-template for more information
using PurchaseRequester.Application.Database;
using PurchaseRequester.Application.Requests.Commands;
using PurchaseRequester.Application.Requests.Queries;
using PurchaseRequester.Domain.Requests;
using PurchaseRequester.Persistence.Requests;
using PurchaseRequester.UI.Console.Requests.Repository;

Console.WriteLine("Hello, World!");
IDatabaseService database = new RequestDbContext();
IGetAllRequestList getAllRequestList = new GetAllRequestList(database);
IAddRequest createARequest = new AddRequest(database);
IRemoveRequest removeARequest = new RemoveRequest(database);    

RequestRepository repo = new RequestRepository(createARequest, getAllRequestList, removeARequest);

Request request = new Request()
{
    PartNo = "123"
};

repo.AddARequest(request);
repo.RemoveRequest(request);

Console.WriteLine("Items in db: ");
foreach (Request r in repo.GetAllRequests())
{
    Console.WriteLine(r.PartNo);
}
