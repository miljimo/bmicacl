using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ViewModels
{

    public class BMIStruct : BaseProperty
    {
        private double height, weight, result;

        public BMIStruct()
        {
            height = 10;
            weight = 30;
            result = 2;
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if(height != value)
                {
                    height = value;
                    OnPropertyChanged(nameof(Height));
                }
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (weight != value)
                {
                    weight = value;
                    OnPropertyChanged(nameof(Weight));
                }
            }
        }

        public double Result
        {
            get
            {
                return result;
            }
            set
            {
                if (value != result)
                {
                    result = value;
                    OnPropertyChanged("Result");
                }
            }
        }

        public void Calculate()
        {
            if (Weight != 0)
                Result = Height / Weight;
            else
                Result = 0;
        }
    }


    public class AddBMIViewModel: BaseViewModel
    {
        private BMIStruct bmiData;
        private string message;
        private ICommand calculateBMICommand;


        public AddBMIViewModel()
            :base()
        {
            bmiData = new BMIStruct();
        }

        public BMIStruct BMIData
        {
            get
            {
                return bmiData;
            }
            set
            {
                if(bmiData != value)
                {
                    bmiData = value;
                    OnPropertyChanged(nameof(BMIData));
                }
            }
         
        }

       

        public ICommand CalculateBMICommand
        {
            get
            {
               return calculateBMICommand ?? (calculateBMICommand = CreateCommand(OnCalculateBMIEvent));
            }
        }

        public String Message
        {
            get
            {
                return message;
            }
            set
            {
                if(message != value)
                {
                    message = value;
                    OnPropertyChanged(nameof(Message));
                }
            }
        }

        /// <summary>
        ///  The function is use to caculate the BMI.
        /// </summary>
        /// <param name="obj"></param>
        private void OnCalculateBMIEvent(object obj)
        {

            BMIData.Calculate();
            BMIData.Height = 2;


        }
    }
}
