using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lba09_Gesture.ViewModels
{
    public  class SwipeCommandPageViewModel:INotifyPropertyChanged
    {
        public ICommand SwipeCommand => new Command<string>(Swipe);

        public string SwipeDirection { get; private set; }

        public SwipeCommandPageViewModel()
        {
            SwipeDirection = "You swiped: ";
        }

        void Swipe(string value)
        {
            SwipeDirection = $"You swiped: {value}";
            OnPropertyChanged("SwipeDirection");
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
