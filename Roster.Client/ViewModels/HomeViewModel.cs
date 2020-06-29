using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Roster.Client.Models;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private string _title = "Roster App";

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(() => Title = "Roster App (v2.0)");
            People.Add(new Person(){Name = "Delores Feil", Company = "Legros Group"});
            People.Add(new Person(){Name = "Ann Zboncak", Company = "Ledner - Ferry" });
            People.Add(new Person(){Name = "Jaime Lesch", Company = "Herzog and Sons" });
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public Command UpdateApplicationCommand { get; }

        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}