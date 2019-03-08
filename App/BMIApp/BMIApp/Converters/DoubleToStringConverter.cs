using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converters
{
    public class DoubleToStringConverter: BaseValueConverter<DoubleToStringConverter>
    {
        public DoubleToStringConverter()
        {
        }

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
            double dbValue = (double)value;
           string result  = dbValue.ToString();

            return result;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double result = 0;
            Double.TryParse((string)(value), out result);
            return result;

        }

    }
}
