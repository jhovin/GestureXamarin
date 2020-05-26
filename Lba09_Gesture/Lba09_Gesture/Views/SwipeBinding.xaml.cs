using Lba09_Gesture.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lba09_Gesture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeBinding : ContentPage
    {
        public SwipeBinding()
        {
            InitializeComponent();

            BindingContext = new SwipeCommandPageViewModel();
        }
    }
}