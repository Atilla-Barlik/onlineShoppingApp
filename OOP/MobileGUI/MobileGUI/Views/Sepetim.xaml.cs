using MobileGUI.Models;
using MobileGUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileGUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sepetim : ContentPage
    {
        private string imageSource;
        private string productName;
        private string price;
        public Sepetim()
        {
            InitializeComponent();
            lstProducts.ItemsSource = Model.list;
        }
        public Sepetim(string image,string productName,string price)
        {
            InitializeComponent();
            this.imageSource = image;
            this.productName = productName;
            this.price = price;
            Add();
            lstProducts.ItemsSource = obList;
        }
        ObservableCollection<SubProductItem> obList;
        public void Add()
        {
            obList = new ObservableCollection<SubProductItem>();
            obList.Add(new SubProductItem
            {
                ImageSource = imageSource,
                Product = productName,
                Price = price
            });

        }


    }
}