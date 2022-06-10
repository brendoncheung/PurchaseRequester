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
using PurchaseRequester.UI.WPF.Requests.ViewModel;

namespace PurchaseRequester.UI.WPF.Requests.Controls
{
    /// <summary>
    /// Interaction logic for RequestListView.xaml
    /// </summary>
    public partial class RequestListView : UserControl
    {
        private readonly RequestListViewModel requestListViewModel;

        public RequestListView(RequestListViewModel requestListViewModel)
        {
            InitializeComponent();
            this.requestListViewModel = requestListViewModel;
        }
    }
}
