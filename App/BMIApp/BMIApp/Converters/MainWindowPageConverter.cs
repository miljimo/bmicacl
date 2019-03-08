using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Converters
{
    public enum MainPageType
    {
        LoginPageType,
        DashboardType
    }
    class MainWindowPageConverter : BasePageConverter<MainPageType, BaseViewModel>
    {


        protected override BaseViewModel OnRequestViewModel(MainPageType pageId, object parameter, CultureInfo culture)
        {
            BaseViewModel Model = null;

            switch (pageId)
            {
                case MainPageType.LoginPageType:
                    break;
                case MainPageType.DashboardType:
                    Model = new DashBoardModelView();
                    break;
                default:
                    break;
            }
            return Model;
        }
    }
}
