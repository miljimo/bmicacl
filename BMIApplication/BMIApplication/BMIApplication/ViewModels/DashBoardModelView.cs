



namespace BMIApplication.ViewModels
{
    using BMIApplication.Converters;


    public  class DashBoardModelView:  BaseViewModel
    {
       private DashBoardPageType pageType;


        public DashBoardModelView()
        {
            //The default page to load.
            //when this model is created.
            pageType = DashBoardPageType.AddRecordType;
        }

        /// <summary>
        /// The function will be use to load the page type.
        /// </summary>
        public DashBoardPageType PageType
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
