using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BMIApplication.AttachProperties
{
    /// <summary>
    ///  The class is an attachment property to added a hint foregroud
    /// </summary>
    public class TextForegroundProperty : BaseAttachedProperty<TextForegroundProperty, Brush>
    {
       public static readonly DependencyProperty ForegroundProperty = CreateProperty("Foreground");

        /// <summary>
        ///  The function set Foreground color of the text 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="foreground"></param>
       public static void SetForeground(DependencyObject d, Brush foreground)
        {
            SetValue(d, ForegroundProperty,foreground);
        }

        /// <summary>
        ///  Get the background color
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Brush GetForeground(DependencyObject d)
        {
           return  GetValue(d, ForegroundProperty);
        }

        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
          /// Do nothing 
        }
    }
}
