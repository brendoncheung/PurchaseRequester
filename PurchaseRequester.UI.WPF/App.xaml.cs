using Microsoft.Extensions.DependencyInjection;
using PurchaseRequester.Core.Database;
using PurchaseRequester.Core.Requests.Commands;
using PurchaseRequester.Core.Requests.Queries;
using PurchaseRequester.Persistence.Requests;
using PurchaseRequester.UI.WPF.Repository.Requests;
using PurchaseRequester.UI.WPF.Requests.AddRequests.ViewModel;
using PurchaseRequester.UI.WPF.Requests.HistoryRequests.ViewModel;
using PurchaseRequester.UI.WPF.Requests.ShowRequests.ViewModel;
using System;
using System.Windows;

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
            // Services
            service.AddTransient<IAddRequest, AddRequest>();
            service.AddTransient<IGetAllRequestList, GetAllRequestList>();

            // Database
            service.AddSingleton<IDatabaseService, RequestDbContext>();

            // Repositories
            service.AddSingleton<RequestRepository>();

            // ViewModel injection
            service.AddSingleton<MainWindowViewModel>();
            service.AddSingleton<AddRequestViewModel>();
            service.AddSingleton<ShowAllRequestViewModel>();
            service.AddSingleton<HistoryRequestViewModel>();

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
