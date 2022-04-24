using MobileGUI.Models;
using MobileGUI.Services;
using MobileGUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileGUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();

            ürünler item = new ürünler();
            item.AddProducts();

            

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstProducts.ItemsSource = searchListModel.list.Where(s => s.Product.StartsWith(e.NewTextValue));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as SubProductItem;

            Model.list.Add(item);
            await DisplayAlert(item.Product, " ürünü sepete eklendi.", "ok");
        }
    }
}