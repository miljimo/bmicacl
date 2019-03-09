


namespace BMIApplication.ViewModels
{
    using System;
    using System.Windows.Input;

    public class BMICalculatorViewModel : BaseViewModel
    {
     
        private string message;
        private ICommand calculateBMICommand;
        private float height;
        private float weight;
        private float result;


        public BMICalculatorViewModel()
            :base()
        {
            height = 0;
            weight = 0;
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
                    RaisePropertyChanged(nameof(Message));
                }
            }
        }

        /// <summary>
        /// Get and Set the height
        /// </summary>
        public float Height
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
                }
            }
        }

        /// <summary>
        /// Get and Set the weight
        /// </summary>
        public float Weight
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
                }
            }
        }

        /// <summary>
        ///  Get and Set the BMI result.
        /// </summary>
        public float Result
        {
            get
            {
                return result;
            }
            set
            {
                if(result != value)
                {
                    result = value;
                    RaisePropertyChanged(nameof(Result));
                }
            }
        }


        /// <summary>
        ///  The function is use to caculate the BMI.
        /// </summary>
        /// <param name="obj"></param>
        private void OnCalculateBMIEvent(object obj)
        {
            float result = 0;
            try
            {
                result = height / weight;
            }
            catch(Exception ex)
            {
                Message = ex.Message;
                result = 0;
            }
            Result = result;
        }
    }
}
