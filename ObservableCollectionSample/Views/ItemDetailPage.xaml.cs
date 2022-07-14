using System.ComponentModel;
using Xamarin.Forms;
using ObservableCollectionSample.ViewModels;

namespace ObservableCollectionSample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
