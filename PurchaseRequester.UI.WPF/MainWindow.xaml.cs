using PurchaseRequester.UI.WPF.Common;
using PurchaseRequester.UI.WPF.Requests.AddRequests.ViewModel;
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
            
            ViewModel.SelectViewModel = ViewModel.ShowRequestViewModel;
            ViewModel.ShowRequestViewModel.GetAllRequest();
        }

        private void MyRequestButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void AddRequestButton_Clicked(object sender, RoutedEventArgs e)
        {
            ViewModel.SelectedViewModel = ViewModel.AddRequestViewModel;
        }

        private void SavedRequestButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void HistorytButton_Clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
