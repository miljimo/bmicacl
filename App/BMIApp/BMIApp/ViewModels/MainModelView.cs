

namespace ViewModels
{
    using Converters;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   
    public class MainModelView: BaseViewModel
    {
        private MainPageType pageType;

        public MainModelView()
        {
            pageType = MainPageType.DashboardType;
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
                    OnPropertyChanged(nameof(PageType));
                }
            }
        }
    }
}
