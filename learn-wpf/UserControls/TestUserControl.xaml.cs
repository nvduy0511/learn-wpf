using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace learn_wpf
{
    /// <summary>
    /// Interaction logic for TestUserControl.xaml
    /// </summary>
    public partial class TestUserControl : UserControl
    {
        public event RoutedEventHandler ButtonClick;
        private void ActionExecuting(object sender, RoutedEventArgs e)
        {
            if (ButtonClick != null)
            {
                ButtonClick.Invoke(this, new RoutedEventArgs());
            }
        }
        public string ContentTextBox
        {
            get { return (string)GetValue(ContentTextBoxProperty); }
            set { SetValue(ContentTextBoxProperty, value); }
        }

        public static readonly DependencyProperty ContentTextBoxProperty =
            DependencyProperty.Register("ContentTextBox", typeof(string), typeof(TestUserControl), new PropertyMetadata(""));



        public string ContentButton
        {
            get { return (string)GetValue(ContentButtonProperty); }
            set { SetValue(ContentButtonProperty, value); }
        }

        
        public static readonly DependencyProperty ContentButtonProperty =
            DependencyProperty.Register("ContentButton", typeof(string), typeof(TestUserControl), new PropertyMetadata("Oke Click"));


        public TestUserControl()
        {
            InitializeComponent();
        }
    }
}
