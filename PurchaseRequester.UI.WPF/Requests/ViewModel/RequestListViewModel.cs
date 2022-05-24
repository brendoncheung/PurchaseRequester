using PurchaseRequester.Domain.Requests;
using PurchaseRequester.UI.WPF.Repository.Requests;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PurchaseRequester.UI.WPF.Requests.ViewModel
{
    public class RequestListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Request> Requests;
        private readonly RequestRepository repository;


        public event PropertyChangedEventHandler? PropertyChanged;

        public RequestListViewModel(ObservableCollection<Request> request, RequestRepository repository)
        {
            this.Requests = request;
            this.repository = repository;
        }

        public void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public void LoadAllRequests()
        {
            Requests.Clear();
            repository.GetRequests().ForEach(r => Requests.Add(r));
        }
         
    }
}
