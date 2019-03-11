

namespace BMIApplication.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public 
        enum BMICategoryType
    {
        NORMAL,
        UNDERR_WEIGHT,
        OVER_WEIGHT,
        OBESS
    }

    /// <summary>
    ///  The data type for the view model.
    /// </summary>
    public class BMIDataType : BaseViewModel
    {
        private DateTime        registeredDate;
        private BMICategoryType categoryType;
        private float           height;
        private float           width;


        /// <summary>
        /// Get the register object.
        /// </summary>
        public  DateTime RegisteredDate
        {
            get
            {
                return registeredDate;
            }
            set
            {
                if(registeredDate != value)
                {
                    registeredDate = value;
                    RaisePropertyChanged(nameof(RegisteredDate));
                }
            }
        }

        /// <summary>
        ///  The get the category
        /// </summary>
        public BMICategoryType CategoryType
        {
            get
            {
                return categoryType;
            }
            set
            {
                if(categoryType != value)
                {
                    categoryType = value;
                    RaisePropertyChanged(nameof(CategoryType));
                }
            }
        }
    }

    public class UserBMITableViewModel : BaseViewModel
    {
        private IList<BMIDataType> userBMIData;

        UserBMITableViewModel()
        {
           
        }

        IList<BMIDataType>  UserBMIData
        {
            get
            {
              return userBMIData;
            }
        }
    }
}
