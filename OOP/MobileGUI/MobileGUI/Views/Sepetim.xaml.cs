﻿using MobileGUI.Models;
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
        
        public Sepetim()
        {
            InitializeComponent();
            lstProducts.ItemsSource = Model.list;
        }
        


    }
}