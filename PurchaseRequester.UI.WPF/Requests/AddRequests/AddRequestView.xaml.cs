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
using PurchaseRequester.UI.WPF.Requests.AddRequests.ViewModel;

namespace PurchaseRequester.UI.WPF.Requests.AddRequests
{
    /// <summary>
    /// Interaction logic for AddRequestView.xaml
    /// </summary>
    public partial class AddRequestView : UserControl
    {
        public AddRequestViewModel ViewModel { get; private set; }

        public AddRequestView()
        { 
            InitializeComponent();

            this.Loaded += AddRequestView_Loaded;
        }

        private void SubmitButton_Clicked(object sender, RoutedEventArgs e)         
        {
            ViewModel.AddRequest(new Request { PartNo="123" });
        }

        private void SaveButton_Clicked(object sender, RoutedEventArgs e)
        {
        }

        private void CancelButton_Clicked(object sender, RoutedEventArgs e)
        {

        }

        public void AddRequestView_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel = (AddRequestViewModel)DataContext;
            MessageBox.Show(ViewModel.ToString());
        }
    }
}
