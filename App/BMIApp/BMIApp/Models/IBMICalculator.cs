using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIApp.Models
{
    struct UserCredential
    {
        private string uid;
        private string lastname;
        private string surname;
    }
     

  
    public interface  IBMICalculator
    {
        double Calculate(double mass, double height);
    }



    public class BMICalculator : IBMICalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double Calculate(double mass, double height)
        {
            double result = 0;

            try
            {
                result = mass / height;
            }
            catch(Exception err)
            {
                throw err;
            }

            return result;
        }
    }



}
