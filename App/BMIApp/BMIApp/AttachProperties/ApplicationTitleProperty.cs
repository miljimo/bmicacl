using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace UI.AttachProperties
{
    public class ApplicationTitleProperty : BaseAttachedProperty<ApplicationTitleProperty, string>
    {


        public static readonly DependencyProperty TitleProperty = CreateProperty("Title");


        /// <summary>
        ///  The function set the dependency property title value.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="title"></param>
        public static void SetTitle(DependencyObject d, string title)
        {
            SetValue(d, TitleProperty, title);
        }

        /// <summary>
        ///  The method get the dependency property value
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string GetTitle(DependencyObject d)
        {
            return GetValue(d, TitleProperty);
        }

        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
           
        }
    }
}
