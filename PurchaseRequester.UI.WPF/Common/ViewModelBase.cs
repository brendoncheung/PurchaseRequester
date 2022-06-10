using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequester.UI.WPF.Common
{
    public class ViewModelBase : INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void RaisedPropertChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual Task LoadAsync() => Task.CompletedTask;
    }
}
