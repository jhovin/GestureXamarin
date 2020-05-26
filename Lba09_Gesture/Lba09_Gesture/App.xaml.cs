using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lba09_Gesture.Services;
using Lba09_Gesture.Views;

namespace Lba09_Gesture
{
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }


        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
