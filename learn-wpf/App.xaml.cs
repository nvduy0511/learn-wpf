using Dna;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace learn_wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override async void OnStartup(StartupEventArgs e)
        {
            // Let the base application do what it needs
            base.OnStartup(e);
            // Setup the main application 
            ApplicationSetupAsync();
        }

        /// <summary>
        /// Configures our application ready for use
        /// </summary>
        private void ApplicationSetupAsync()
        {
            // Setup the Dna Framework
            Framework.Construct<DefaultFrameworkConstruction>()
                .AddFileLogger()
                .AddFasettoWordViewModels()
                .AddFasettoWordClientServices()
                .Build();
        }
    }
}
