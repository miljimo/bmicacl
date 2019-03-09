

namespace BMIApplication.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;

    /// <summary>
    /// 
    /// </summary>
    public class InverseBoolConverter : BaseValueConverter<InverseBoolConverter>
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibility = Visibility.Visible;

            if ((bool)value == true)
            {
                visibility = Visibility.Hidden;
            }
            return visibility;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool result = false;
            Visibility visibility = (Visibility)value;
            if ((visibility == Visibility.Hidden)
                  || (visibility == Visibility.Collapsed))
            {
                result = true;
            }
            return result;
        }
    }
}
