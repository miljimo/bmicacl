using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseProperty
    {
        private PropertyChangedEventHandler __PropertyChangedEventHandler;
        private  object raisePropertyLocker = new object();
        /// <summary>
        /// The property change event handle
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
       

        /// <summary>
        ///  Raise property change event on C# Property.
        /// </summary>
        /// <param name="Name">The name of the property variable</param>
        protected void OnPropertyChanged(string Name)
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }
    }
}
