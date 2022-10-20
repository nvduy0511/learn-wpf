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
    public class LoginViewModel:BaseViewModel
    {
      
        public string UserName { get; set; }
        public string PassWord { get; set; }
      

        public ICommand LoginCommand { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand((p) =>
            {
                ((TextBlock)p).Text = UserName+PassWord;
            });
        }


    }
}
