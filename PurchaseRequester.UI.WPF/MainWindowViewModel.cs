using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.UI.WPF.Common;


namespace PurchaseRequester.UI.WPF;

public class MainWindowViewModel : ViewModelBase
{

    private ViewModelBase? _selectedViewModel;

    public ViewModelBase? SelectedViewModel
    {
        get { return _selectedViewModel; }
        set { _selectedViewModel = value; RaisedPropertChanged(); }
    }

    public MainWindowViewModel()
    {
        
    }
}
