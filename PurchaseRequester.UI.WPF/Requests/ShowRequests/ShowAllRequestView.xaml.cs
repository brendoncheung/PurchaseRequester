using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PurchaseRequester.Domain.Requests;
using PurchaseRequester.UI.WPF.Requests.ShowRequests.ViewModel;

namespace PurchaseRequester.UI.WPF.Requests.ShowRequests
{
    /// <summary>
    /// Interaction logic for ShowAllRequestView.xaml
    /// </summary>
    public partial class ShowAllRequestView : UserControl
    {

        public ShowAllRequestViewModel ViewModel { get; private set; }
       
        public ShowAllRequestView()
        {
            InitializeComponent();
            this.Loaded += ShowAllRequestView_Loaded;
        }


        private void Refresh_Clicked(object sender, RoutedEventArgs e)
        {
            LoadRequests();
        }

        private void ShowAllRequestView_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel = (ShowAllRequestViewModel)DataContext;
            LoadRequests();
        }

        private void LoadRequests()
        {
            dataGrid.ItemsSource = ViewModel.GetAllRequest();
        }
    }
}
