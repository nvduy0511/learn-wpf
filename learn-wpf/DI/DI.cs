using Dna;

namespace learn_wpf
{
    /// <summary>
    /// A shorthand access class to get DI services with nice clean short code
    /// </summary>
    public static class DI
    {
        public static ApplicationViewModel ViewModelApplication => Framework.Service<ApplicationViewModel>();
        public static IUIManager UI => Framework.Service<IUIManager>();

    }
}
