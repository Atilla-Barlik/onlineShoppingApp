using MobileGUI.Models;
using MobileGUI.Services;
using MobileGUI.ViewModels;
using MobileGUI.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileGUI
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            searchListModel.list = new ObservableCollection<SubProductItem>();
            ürünler ürünler = new ürünler();
            ürünler.AddProducts();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
