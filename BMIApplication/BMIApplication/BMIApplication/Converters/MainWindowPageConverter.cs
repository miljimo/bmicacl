

namespace BMIApplication.Converters
{
    using ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum MainPageType
    {
        LoginPageType,
        DashboardType,
        RegisterPageType
    }
   public  class MainWindowPageConverter : BasePageConverter<MainPageType, BaseViewModel>
    {


        protected override BaseViewModel OnRequestViewModel(MainPageType pageId, object parameter, CultureInfo culture)
        {
            BaseViewModel viewModel = null;

            switch (pageId)
            {
                case MainPageType.LoginPageType:
                    viewModel = new UserLoginViewModel();
                    break;
                case MainPageType.DashboardType:
                    viewModel = new DashBoardModelView();
                    break;
                case MainPageType.RegisterPageType:
                    viewModel = new CreateUserAccountViewModel();
                    break;
                default:
                    break;
            }
            return viewModel;
        }
    }
}
