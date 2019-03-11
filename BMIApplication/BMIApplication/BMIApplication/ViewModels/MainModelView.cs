

namespace BMIApplication.ViewModels
{
    using BMIApplication.Converters;
    using System;
    using System.Windows;
    using System.Windows.Input;

    public class MainModelView: BaseViewModel
    {
        private MainPageType pageType;
        private ICommand closeWindowCommand;

        public MainModelView()
        {
            pageType = MainPageType.LoginPageType;
        }

      

        /// <summary>
        ///   The current Page of the application
        /// </summary>
        public MainPageType PageType
        {
            get
            {
                return pageType;
            }
            set
            {
                if(pageType != value)
                {
                    pageType = value;
                    RaisePropertyChanged(nameof(PageType));
                }
            }
        }
    }
}
