using Roguelike_mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roguelike_mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}