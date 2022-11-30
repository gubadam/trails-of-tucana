using System;
//using TrailsOfTucana.Services;
using TrailsOfTucana.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrailsOfTucana {
    public partial class App : Application {

        public App() {
            InitializeComponent();
            MainPage = new MainContentPage();
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
