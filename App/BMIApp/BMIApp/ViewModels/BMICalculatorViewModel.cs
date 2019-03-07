using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ViewModels
{

    public struct BMIStruct
    {
        public double Height;
        public double Weight;
    }


    public class BMICalculatorViewModel: BaseViewModel
    {
        private BMIStruct bmiData;
        private double result;
        private string message;
        private ICommand textChangedCommand;


        public BMICalculatorViewModel()
            :base()
        {
            bmiData = new BMIStruct
            {
                Height = 0,
                Weight = 0
            };
            result = 0;
        }

        public BMIStruct BMIData
        {
            get
            {
                return bmiData;
            }
        }

        public double Result
        {
            get
            {
                return result;
            }
           protected set
            {
                if (value != result)
                {
                    result = value;
                    RaisePropertyChanged(nameof(Result));
                }
            }
        }

        public ICommand CalculateCommand
        {
            get
            {
               return textChangedCommand ?? (textChangedCommand = CreateCommand(OnCalculateBMIEvent));
            }
        }

        public string Message
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
                    RaisePropertyChanged(Message);
                }
            }
        }

        /// <summary>
        ///  The function is use to caculate the BMI.
        /// </summary>
        /// <param name="obj"></param>
        private void OnCalculateBMIEvent(object obj)
        {
            try
            {
                Result = BMIData.Weight / BMIData.Height;
            }
            catch(Exception err)
            {
                Message = err.Message;
                Result = 0;
            }
        }
    }
}
