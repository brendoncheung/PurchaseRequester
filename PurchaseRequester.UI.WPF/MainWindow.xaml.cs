using PurchaseRequester.UI.WPF.Requests.ViewModel;
using System.Windows;

namespace PurchaseRequester.UI.WPF
{ 
    public partial class MainWindow : Window
    {
        public readonly RequestListViewModel ViewModel;

        public MainWindow(RequestListViewModel ViewModel)
        {
            InitializeComponent();
            this.ViewModel = ViewModel;
        }

        private void HomeButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void MyRequestButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void AddRequestButton_Clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
