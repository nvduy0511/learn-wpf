using learn_wpf.Pages;
using learn_wpf.ViewModels;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_wpf
{
    public static class IoC
    {

        public static IKernel Kernel { get; private set; } = new StandardKernel();

    
        public static void Setup()
        {
            // Bind all required view models
            BindViewModels();
        }

        private static void BindViewModels()
        {
            // Bind to a single instance of Application view model
            Kernel.Bind<LoginViewModel>().ToSelf().InSingletonScope();

        }

       
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
