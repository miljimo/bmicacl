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
            string Result = "89";

            return Result;
        }
    }
}
