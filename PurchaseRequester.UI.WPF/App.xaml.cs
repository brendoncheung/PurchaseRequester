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
using PurchaseRequester.UI.WPF.Requests;
using Microsoft.Extensions.DependencyInjection;
using PurchaseRequester.UI.WPF.Requests.AddRequests.ViewModel;
using PurchaseRequester.UI.WPF.Requests.ShowRequests.ViewModel;

namespace PurchaseRequester.UI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly IServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection service = new();

            ConfigureServices(service);
            serviceProvider = service.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection service)
        {
            service.AddTransient<IDatabaseService, RequestDbContext>();
            service.AddTransient<AddRequest>();
            service.AddTransient<GetAllRequestList>();
            service.AddTransient<RequestRepository>();

            // ViewModel injection

            service.AddTransient<RequestListViewModel>();
            service.AddTransient<MainWindowViewModel>();
            service.AddTransient<AddRequestViewModel>();
            service.AddTransient<ShowAllRequestViewModel>();

            service.AddTransient<MainWindow>();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();

        }
    }
}
