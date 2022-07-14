using System;
using System.Collections.Generic;
using ObservableCollectionSample.ViewModels;
using Xamarin.Forms;

namespace ObservableCollectionSample.Views
{
    public partial class CollectionPage : ContentPage
    {
        public CollectionPage()
        {
            InitializeComponent();
            BindingContext = new CollectionViewModel();
        }
    }
}
