using System.Windows.Input;
using static learn_wpf.DI;

namespace learn_wpf
{
    public class HomeViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string Pass { get; set; }
        public bool RememberMe { get; set; }
        public string Result { get; set; }
        public bool IsRunning { get; set; }

        public ICommand LoginCommand { get; set; }
        public ICommand ShowMessageCommand { get; set; }

        public HomeViewModel()
        {
            //LoginCommand = new RelayParameterizedCommand(async (p) =>
            //{
            //    await RunCommandAsync(() => IsRunning, async () =>
            //    {
            //    });
            //});

            ShowMessageCommand = new RelayCommand( async () =>
           {
               await UI.ShowMessage(new MessageBoxDialogViewModel() { Message = "This is my message send from HOME PAGE", OkText = "OK", Title = "Message" });   
           });
        }
    }
}
