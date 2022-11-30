using System;
using System.Collections.Generic;
using TrailsOfTucana.ViewModels;
using TrailsOfTucana.Views;
using Xamarin.Forms;

namespace TrailsOfTucana {
    public partial class AppShell : Xamarin.Forms.Shell {
        public AppShell() {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
