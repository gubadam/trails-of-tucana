using System;
using System.Collections.Generic;
using System.ComponentModel;
using TrailsOfTucana.Models;
using TrailsOfTucana.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrailsOfTucana.Views {
    public partial class NewItemPage : ContentPage {
        public Item Item { get; set; }

        public NewItemPage() {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}