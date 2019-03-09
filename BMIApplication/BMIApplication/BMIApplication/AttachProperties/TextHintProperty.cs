

namespace BMIApplication.AttachProperties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;

    public class TextHintProperty :  BaseAttachedProperty<TextHintProperty,string>
    {

        public static readonly DependencyProperty HintProperty = CreateProperty("Hint");

        public static string GetHint(DependencyObject d)
        {
            return GetValue(d, HintProperty);
        }

        public static  void SetHint(DependencyObject d , string value)
        {
            SetValue(d, HintProperty, value);
        }

    
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pBox = d as PasswordBox;
            if(pBox != null)
            {
                pBox.PasswordChanged -= OnTextChanged;
                pBox.PasswordChanged += OnTextChanged;
            }
            else
            {
                TextBoxBase txtBox = d as TextBoxBase;
                if(txtBox != null)
                {
                    txtBox.TextChanged -= OnTextChanged;
                    txtBox.TextChanged += OnTextChanged;
                }
            }
            IsTextEmptyProperty.SetIsEmpty(d, false);
        }

        /// <summary>
        ///  On Password changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pBox = sender as PasswordBox;
            bool HasText = false;
            if( pBox != null)
            {
               HasText  =  !string.IsNullOrWhiteSpace(pBox.Password);
            }
            else
            {
                 TextBox txtBox = sender as TextBox;
                 if (txtBox != null)
                 {
                     HasText = !string.IsNullOrWhiteSpace(txtBox.Text);
                 }
            }

            IsTextEmptyProperty.SetIsEmpty((DependencyObject)sender, HasText);
        }
  
}
}
