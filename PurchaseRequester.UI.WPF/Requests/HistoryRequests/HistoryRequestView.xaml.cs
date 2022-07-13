using PurchaseRequester.UI.WPF.Requests.HistoryRequests.ViewModel;
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

namespace PurchaseRequester.UI.WPF.Requests.HistoryRequests
{
    /// <summary>
    /// Interaction logic for HistoryRequestView.xaml
    /// </summary>
    public partial class HistoryRequestView : UserControl
    {
        public HistoryRequestViewModel ViewModel { get; private set; }
        
        public HistoryRequestView()
        {
            InitializeComponent();
            Loaded += HistoryRequestView_Loaded;
        }

        public void HistoryRequestView_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel = (HistoryRequestViewModel)DataContext;
            ViewModel.ShowAllCompletedRequests();
        }
    }
}
