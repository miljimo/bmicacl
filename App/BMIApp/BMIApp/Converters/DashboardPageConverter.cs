

namespace Converters
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ViewModels;

    public enum DashBoardPageType
    {
       AddRecordType,
       ViewRecordType,
       ProfileRecord
    }
    /// <summary>
    ///  The converter convert Page Enum to a model view class and the xaml datatemplate automatically attached the view 
    ///  associated with the model.
    /// </summary>
    public class DashboardPageConverter : BasePageConverter<DashBoardPageType, BaseViewModel>
    {
        protected override BaseViewModel OnRequestViewModel(DashBoardPageType pageId, object parameter, CultureInfo culture)
        {
            BaseViewModel Model = null;
               
            switch(pageId)
            {
                case DashBoardPageType.AddRecordType:
                    Model = new AddBMIViewModel();
                    break;
                default:
                    break;
            }
            return Model;
        }
    }
}
