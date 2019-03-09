using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMIApplication.AttachProperties
{
    public class IsTextEmptyProperty : BaseAttachedProperty<IsTextEmptyProperty, bool>
    {

        public static readonly DependencyProperty IsEmptyProperty = CreateProperty("IsEmpty");

        public static void SetIsEmpty(DependencyObject d , bool value)
        {
            SetValue(d, IsEmptyProperty, value);
        }

        public static bool GetIsEmpty(DependencyObject d)
        {
            return GetValue(d, IsEmptyProperty);
        }

        /// <summary>
        ///  The method will be called when the value is set.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //do nothing
        }
    }
}
