

namespace Converters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Data;
    using System.Windows.Markup;
    /// <summary>
    ///  The base converter class 
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class BaseValueConverter<Parent> : MarkupExtension,  IValueConverter
        where Parent : BaseValueConverter<Parent>
   {

       protected static Parent __Converter = null;

       public static Parent Instance
       {
           get
           {
               return __Converter;
           }
       }

       #region Mark Extension
       /// <summary>
       ///   Markup Extension Object.
       /// </summary>
       /// <param name="serviceProvider"> The serive provider</param>
       /// <returns>Return the current object class</returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return __Converter ?? ( __Converter = (Parent)this);
        }
       #endregion

        #region Value Converter
        /// <summary>
       ///   Convert the value to the required object
       /// </summary>
       /// <param name="value">The value to convert</param>
       /// <param name="targetType">The valye target type</param>
       /// <param name="parameter">The value parameter</param>
       /// <param name="culture">The current System Culture</param>
       /// <returns></returns>
        public abstract object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture);
       
       /// <summary>
       ///   Convert back the value
       /// </summary>
       /// <param name="value">The value to convert back</param>
       /// <param name="targetType"> The target value</param>
       /// <param name="parameter">The parameters </param>
       /// <param name="culture">The current culture</param>
       /// <returns></returns>
        public virtual object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }

        #endregion

    }
}
