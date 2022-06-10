using PurchaseRequester.UI.WPF.Common;
using PurchaseRequester.UI.WPF.Requests.AddRequests.ViewModel;
using PurchaseRequester.UI.WPF.Requests.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace PurchaseRequester.UI.WPF
{ 
    public partial class MainWindow : Window
    {
        public readonly MainWindowViewModel ViewModel;

        public MainWindow(MainWindowViewModel ViewModel)
        {
            InitializeComponent();
            this.ViewModel = ViewModel;
            DataContext = ViewModel;
        }

        private void HomeButton_Clicked(object sender, RoutedEventArgs e)
        {
            var vm = (MainWindowViewModel)((Button)sender).DataContext;
            ViewModel.SelectViewModel = vm.ShowRequestViewModel;

        }

        private void MyRequestButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void AddRequestButton_Clicked(object sender, RoutedEventArgs e)
        {
            var vm = (MainWindowViewModel)((Button)sender).DataContext;
            ViewModel.SelectViewModel = vm.AddRequestViewModel;

        }
    }
}
