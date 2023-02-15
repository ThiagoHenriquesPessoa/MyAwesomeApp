using MyAwesomeApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyAwesomeApp.Views
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