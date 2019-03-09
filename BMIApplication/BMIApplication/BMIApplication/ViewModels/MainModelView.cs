

namespace BMIApplication.ViewModels
{
    using BMIApplication.Converters;
   
    public class MainModelView: BaseViewModel
    {
        private MainPageType pageType;

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
