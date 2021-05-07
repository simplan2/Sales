namespace Sales.ViewModels
{
    using Sales.Common.Models;
    using Sales.Services;
    using System;
    using System.Collections.ObjectModel;
    using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

    public class ProductsViewModel: BaseViewModel
    {
        private ApiService apiService;

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { SetValue(ref products, value); }
        }

        public ProductsViewModel()
        {
            apiService = new ApiService();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            var response = await this.apiService.GetList<Product>("", "/api", "/Products");
            if (!response.IsSuccess)
            {
              
            }
        }
    }
}
