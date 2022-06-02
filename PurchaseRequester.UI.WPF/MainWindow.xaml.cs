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

        private void addRequest_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
