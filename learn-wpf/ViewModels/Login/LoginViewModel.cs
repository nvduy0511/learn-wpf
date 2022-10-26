using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using static learn_wpf.DI;

namespace learn_wpf
{
    public class LoginViewModel : BaseViewModel
    {

        public string Username { get; set; }
        public string Pass { get; set; }
        public bool RememberMe { get; set; }
        public string Result { get; set; }
        public bool IsRunning { get; set; }

        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async (p) =>
            {
                await RunCommandAsync(() => IsRunning, async () =>
                {
                    var temp = p as PasswordBox;

                    Properties.Settings.Default.UserName = Username;
                    Properties.Settings.Default.Save();
                    Console.WriteLine($"{Username} -- {temp.Password} -- {RememberMe.ToString()}");
                    await Task.Delay(2000);
                    ViewModelApplication.GoToPage(ApplicationPage.Home);
                });
            });
        }

    }
}
