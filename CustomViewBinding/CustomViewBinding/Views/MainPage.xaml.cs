using CustomViewBinding.ViewModels;
using Xamarin.Forms;

namespace CustomViewBinding.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
