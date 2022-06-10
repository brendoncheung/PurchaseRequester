﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseRequester.UI.WPF.Common;
using PurchaseRequester.UI.WPF.Requests.AddRequests.ViewModel;
using PurchaseRequester.UI.WPF.Requests.ShowRequests.ViewModel;

namespace PurchaseRequester.UI.WPF;

public class MainWindowViewModel : ViewModelBase
{
    public ShowAllRequestViewModel ShowRequestViewModel { get; }
    public AddRequestViewModel AddRequestViewModel { get; }

    private ViewModelBase? _selectedViewModel;

    public ViewModelBase? SelectedViewModel
    {
        get { return _selectedViewModel; }
        set { _selectedViewModel = value; RaisedPropertChanged(); }
    }

    public MainWindowViewModel(
        ShowAllRequestViewModel showRequestViewModel, 
        AddRequestViewModel addRequestViewModel)
    {
        ShowRequestViewModel = showRequestViewModel;
        AddRequestViewModel = addRequestViewModel;

        SetInitialView(showRequestViewModel);
    }

    private void SetInitialView(ViewModelBase showRequestViewModel)
    {
        _selectedViewModel = AddRequestViewModel;
    }

    public ViewModelBase? SelectViewModel
    {
        get => _selectedViewModel;
        set
        {
            _selectedViewModel = value;
            RaisedPropertChanged(nameof(SelectedViewModel));
        }
    }





    
    


}
