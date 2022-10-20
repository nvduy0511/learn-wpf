using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace learn_wpf.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public int CurrentPage { get; set; } = 0;

        public ICommand ChangePage { get; set; }
        public MainWindowViewModel()
        {
            ChangePage = new RelayParameterizedCommand((p) =>
            {
                this.CurrentPage = int.Parse(p.ToString());
            });

        }
    }
}
