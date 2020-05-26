using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Lba09_Gesture.Models;

namespace Lba09_Gesture.Views
{
  
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.TapDemo:
                        MenuPages.Add(id, new NavigationPage(new TapDemo()));
                        break;
                    case (int)MenuItemType.PinchDemo:
                        MenuPages.Add(id, new NavigationPage(new PinchDemo()));
                        break;
                    case (int)MenuItemType.PanDemo:
                        MenuPages.Add(id, new NavigationPage(new PanDemo()));
                        break;
                    case (int)MenuItemType.SwipeDemo:
                        MenuPages.Add(id, new NavigationPage(new SwipeDemo()));
                        break;
                    case (int)MenuItemType.SwipeBinding:
                        MenuPages.Add(id, new NavigationPage(new SwipeBinding()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}