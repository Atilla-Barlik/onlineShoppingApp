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

        private async void lstProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                BackgroundColor = Color.White;
                var selectedProduct = (SubProductItem)e.CurrentSelection[0];
                if (selectedProduct != null)
                {
                    bool answer = await DisplayAlert("Favorilere Ekle", selectedProduct.Product + " adlı ürün favorilere eklensin mi?", "Yes", "No");

                    if (answer)
                    {
                        foreach (var item in searchListModel.list)
                        {
                            if (item.Product == selectedProduct.Product)
                            {
                                item.Favorite = "1";
                                break;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Sistemde bir hata oluştu.", "Ok");
            }
        }
    }
}