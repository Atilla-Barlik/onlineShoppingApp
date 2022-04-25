﻿using MobileGUI.Models;
using MobileGUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MobileGUI.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            List<string> CarouselItems = new List<string>()
            {
                "https://www.file.com.tr/uploads/file/mainslider/11-01-2022-14-47-04-slider.png",
                "https://www.file.com.tr/uploads/file/mainslider/1-03-2022-16-41-39-file-glutensiz-gida.png",
                "https://www.file.com.tr/uploads/file/mainslider/16-02-2022-09-00-00-14-02-2022-15-11-30-harras-slider%20(1)%20(1).png"
            };
            Model.list = new ObservableCollection<SubProductItem>();
            FırsatÜrünleriCarousel.ItemsSource = CarouselItems;
            AddProducts();
            lstProducts.ItemsSource = obProducts;
        }
        ObservableCollection<ProductItem> obProducts;
        public void AddProducts()
        {
            try
            {
                obProducts = new ObservableCollection<ProductItem>();
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://pluse.com.tr/images/thumb/1078.jpg",
                    Product = "Meyve Sebze",
                    ID = "0"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://sandalcisarkuteri.com/wp-content/uploads/2020/06/PASTIRMA-ANTR%C4%B0KOT-KG-300x300.jpg",
                    Product = "Et Tavuk Balık",
                    ID = "1"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://www.festiva.com.tr/img/cms/category_73.jpg",
                    Product = "İçecek",
                    ID = "2"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://www.dramalietmangal.com/wp-content/uploads/2014/07/1-768x512-1-300x300.jpg",
                    Product = "Kahvaltılık Şarküteri",
                    ID = "3"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://i0.wp.com/www.beslendik.com/wp-content/uploads/2018/07/IMG_6677-e1467973823636-300x300.jpg?resize=300%2C300&ssl=1",
                    Product = "Süt ve Süt Ürünleri",
                    ID = "4"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://olgunlar.com.tr/wp-content/uploads/2020/03/resatohumculuk-cendere-bugdaytohumu-300x300.jpg",
                    Product = "Temel Gıda",
                    ID = "5"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://missunlumamulleri.com/wp-content/uploads/2019/04/minti-ekmek-300x300.jpg",
                    Product = "Fırın Pastahane",
                    ID = "6"

                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://ciravonline.com/wp-content/uploads/2021/12/cirav-findikli-bitter-cikolata-1-300x300.jpg",
                    Product = "Atıştırmalık",
                    ID = "7"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://www.g2meksper.com.tr/medias/sys_master/product-images/product-images/h0f/hde/8989364387870/000000000001017890-1-300x300.jpg",
                    Product = "Hazır Yemek",
                    ID = "8"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://missunlumamulleri.com/wp-content/uploads/2021/04/cikolatali-dondurma-300x300.jpg",
                    Product = "Dondurma",
                    ID = "9"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRh7IbL6Al1yxkXZ12CTSL9VyuzFBGepR6M3w&usqp=CAU",
                    Product = "Kişisel Bakım",
                    ID = "10"

                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyTF6Ibq9kej3kLHcJU4wJCWQQTjFBj4MgnA&usqp=CAU",
                    Product = "Kağıt Ürünleri",
                    ID = "11"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtrA81baLUqYusugvNAxs2grK2n1edMBx-Le7gpZUVSg&s",
                    Product ="Ev Temizliği",
                    ID = "12"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://wwwi.globalpiyasa.com/lib/Urun/300/368673e5e2b23b29194be9e5baaca245_1.jpg",
                    Product = "Mutfak Malzemeleri",
                    ID = "13"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://listelik.com/data/xfmg/thumbnail/6/6633-d9f756ce4614d75c7dd4a12d357cfff7.jpg?1570864903",
                    Product = "Bebek",
                    ID = "14"

                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://media-exp1.licdn.com/dms/image/C4D12AQEJIzSR0zmkdw/article-cover_image-shrink_600_2000/0/1540473084510?e=2147483647&v=beta&t=5sVV_L_IrjLoBzO0vcYb5Y_p-KeYsNsqIg8xzZly1Aw",
                    Product = "Glutensiz",
                    ID = "15"
                });
                obProducts.Add(new ProductItem
                {
                    ImageSource = "https://www.bestepebloggers.com/wp-content/uploads/2020/12/kedi-kopek-saril-3010.jpg",
                    Product = "Evcil Dostlar",
                    ID = "16"
                });
            }
            catch (Exception ex)
            {

            }
        }
        
        private void lstProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                BackgroundColor = Color.White;
                var selectedProduct = (ProductItem)e.CurrentSelection[0];
                if (selectedProduct != null)
                    Navigation.PushAsync(new ProductPage(selectedProduct.ID));
                

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Catch girdi", "Ok");
            }
            
        }
    }
}