using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace learn_wpf.ViewModels
{
    public class Window2ViewModel : BaseViewModel
    {
        private Window mWindow;

        public string Num { get; set; } = "From Window2ViewModel";
        public ICommand AddCommand { get; set; }
        public ICommand WindowLoadedCommand { get; set; }

        private Random mRandom;
        public Window2ViewModel()
        {

        }
        public Window2ViewModel(Window window)
        {
            mWindow = window;
            mRandom = new Random();
            AddCommand = new RelayCommand<object>((p) =>
            {
                Num = mRandom.Next().ToString();
            });

            WindowLoadedCommand = new RelayParameterizedCommand((p) =>
            {
                mWindow.Title = "ABC NE";
                ((TextBlock)p).Text = "Nguyen Van DUy";
            });
        }


    }
}
