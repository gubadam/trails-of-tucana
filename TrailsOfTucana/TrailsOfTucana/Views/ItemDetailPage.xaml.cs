using System.ComponentModel;
using TrailsOfTucana.ViewModels;
using Xamarin.Forms;

namespace TrailsOfTucana.Views {
    public partial class ItemDetailPage : ContentPage {
        public ItemDetailPage() {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}