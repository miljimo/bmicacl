
namespace BMIApplication.Converters
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using ViewModels;


    /// <summary>
    ///  The base page converter class
    /// </summary>
    /// <typeparam name="TPageType"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    public abstract class BasePageConverter<TPageType , TModel> : BaseValueConverter<BasePageConverter<TPageType , TModel>>
        where TModel: BaseViewModel 
        where TPageType: struct, IConvertible
       {

        private IParameterBag<TPageType, TModel> __Pages;
        /// <summary>
        /// Get and Set T
        /// </summary>
        public static TModel    CurrentViewModel     = null;
        public static TPageType CurrentPageType      = default(TPageType);


        /// <summary>
        /// Default constructor.
        /// </summary>
        public BasePageConverter()
        {
            __Pages = new ParameterBag<TPageType, TModel>("ViewModels");
        }

        /// <summary>
        ///  The function will convert the value of the object
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            object Result = null;
            TPageType PageType = (TPageType)value;
            if (__Pages.oExist(PageType))
            {
                //Get the model from the bag
                Result = __Pages.oGet(PageType);
            }
            else
            {
                Result = OnRequestViewModel(PageType, parameter, culture);

                if (Result != null)
                {
                    __Pages.oAdd(PageType, Result as TModel);
                }
            }

            if (Result != null)
            {
                CurrentViewModel = Result as TModel;
                CurrentPageType = PageType;
            }

            return CurrentViewModel;
        }
        /// <summary>
        ///Convert back the ViewModel back to the page type.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
          TPageType Result = default(TPageType);

          if(value != null)
          {
              IEnumerator<KeyValuePair<TPageType, TModel>> List = __Pages.oGetEnumerator();

              while(List.MoveNext())
              {
                  KeyValuePair<TPageType, TModel> Pair =  List.Current;

                  if(Pair.Value == value)
                  {
                      Result = Pair.Key;
                      break;
                  }
              }
          }
          return Result;
        }
        /// <summary>
        ///  Request a new  page model to be created.
        ///  
        /// </summary>
        /// <param name="pageId">The page enum type</param>
        /// <param name="parameter">The current paremters required by the page</param>
        /// <param name="culture">The culture of the page</param>
        /// <returns>return TModel type provided.</returns>
        protected abstract TModel OnRequestViewModel(TPageType pageId, object parameter, CultureInfo culture);
       
    }
}
/****************************End File************************************************************/