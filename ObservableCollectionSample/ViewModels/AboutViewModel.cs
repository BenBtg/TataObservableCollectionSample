using System;
using System.Windows.Input;
using ObservableCollectionSample.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ObservableCollectionSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(CollectionPage)));
        }

        public ICommand OpenWebCommand { get; }
    }
}
