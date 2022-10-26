using System;
using System.Diagnostics;
using System.Globalization;

namespace learn_wpf
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public static class ApplicationPageHelpers
    {
        /// <summary>
        /// Takes a <see cref="ApplicationPage"/> and a view model, if any, and creates the desired page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public static BasePage ToBasePage(this ApplicationPage page, object viewModel = null)
        {
            // Find the appropriate page
            switch (page)
            {
                case ApplicationPage.Login:
                    return new LoginPage(viewModel as LoginViewModel);
                case ApplicationPage.Home:
                    return new HomePage(viewModel as HomeViewModel);

                default:
                    return new LoginPage(viewModel as LoginViewModel);
            }
        }

        /// <summary>
        /// Converts a <see cref="BasePage"/> to the specific <see cref="ApplicationPage"/> that is for that type of page
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static ApplicationPage ToApplicationPage(this BasePage page)
        {
            //Find application page that matches the base page
            if (page is HomePage)
                return ApplicationPage.Home;

            if (page is LoginPage)
                return ApplicationPage.Login;

            //Alert developer of issue
            Debugger.Break();
            return default(ApplicationPage);
        }
    }
}
