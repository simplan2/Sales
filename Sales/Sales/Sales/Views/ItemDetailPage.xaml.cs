using Sales.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Sales.Views
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