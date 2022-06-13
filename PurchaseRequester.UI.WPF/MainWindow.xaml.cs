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
        public readonly AddRequestViewModel AddRequestViewModel;

        public MainWindow(MainWindowViewModel ViewModel, AddRequestViewModel addRequestViewModel)
        {
            InitializeComponent();
            this.ViewModel = ViewModel;
            this.AddRequestViewModel = addRequestViewModel;
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

        private void SavedRequestButton_Clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
