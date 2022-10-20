using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace learn_wpf
{
    public class TextBoxAttachedProperty
    {
        public const string CheckLengthPropertyName = "CheckLength";

        public static readonly DependencyProperty CheckLengtProperty
             = DependencyProperty.RegisterAttached(
                 CheckLengthPropertyName,
                 typeof(bool),
                 typeof(TextBoxAttachedProperty),
                 new PropertyMetadata(false, OnCheckLengthChange));

        public static bool GetCheckLength(DependencyObject obj)
        {
            return (bool)obj.GetValue(CheckLengtProperty);
        }

        public static void SetCheckLength(DependencyObject obj, bool value)
        {
            obj.SetValue(CheckLengtProperty,value);
        }

        private static void OnCheckLengthChange(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            TextBox t = obj as TextBox;
            if (t == null)
                return;
            t.TextChanged -= T_TextChanged;
            t.TextChanged += T_TextChanged;
        }

        private static void T_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxAttachedProperty.SetCheckLength((TextBox)sender, ((TextBox)sender).Text.Length > 10);
        }
    }
}
