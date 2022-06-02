using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PurchaseRequester.Core.Database;
using PurchaseRequester.Core.Requests.Commands;
using PurchaseRequester.Core.Requests.Queries;
using PurchaseRequester.Persistence.Requests;
using PurchaseRequester.UI.WPF.Repository.Requests;
using PurchaseRequester.UI.WPF.Requests.ViewModel;

namespace PurchaseRequester.UI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var databaseService = new RequestDbContext();
            var addRequest = new AddRequest(databaseService);
            var getAllRequestList = new GetAllRequestList(databaseService);
            var requestRepository = new RequestRepository(getAllRequestList, addRequest);
            var requestListViewModel = new RequestListViewModel(requestRepository);
            Application.Current.MainWindow = new MainWindow(requestListViewModel);
            Application.Current.MainWindow.Show();

        }
    }
}
