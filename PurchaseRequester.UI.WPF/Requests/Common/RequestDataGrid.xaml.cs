using PurchaseRequester.Domain.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PurchaseRequester.UI.WPF.Requests.Common
{
    /// <summary>
    /// Interaction logic for RequestDataGrid.xaml
    /// </summary>
    public partial class RequestDataGrid : UserControl
    {

        public ObservableCollection<Request> Requests
        {
            get { return (ObservableCollection<Request>)GetValue(RequestsProperty); }
            set { SetValue(RequestsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Requests.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RequestsProperty =
            DependencyProperty.Register("Requests", typeof(ObservableCollection<Request>), typeof(RequestDataGrid));


        public RequestDataGrid()
        {
            InitializeComponent();
        }
    }
}
