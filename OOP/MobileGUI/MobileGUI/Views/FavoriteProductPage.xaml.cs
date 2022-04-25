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
    public partial class FavoriteProductPage : ContentPage
    {
        public FavoriteProductPage()
        {
            InitializeComponent();

            lstProducts.RefreshCommand = new Command(() => {
                //Do your stuff.    
                RefreshData();
                lstProducts.IsRefreshing = false;
            });
        }

        private void RefreshData()
        {
            lstProducts.ItemsSource = null;
            lstProducts.ItemsSource = searchListModel.list.Where(sProducts => sProducts.Favorite == "1");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new HesabımPage());
        }
    }
}