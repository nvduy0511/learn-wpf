using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_wpf
{
    public class Class1: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        public string Test { get; set; }
        public Class1()
        {
            Task.Run(async () =>
           {
               int i = 0;
               while (true)
               {
                   
                   await Task.Delay(500);
                   Test = i++.ToString();
               }
           });
        }

    }
}
