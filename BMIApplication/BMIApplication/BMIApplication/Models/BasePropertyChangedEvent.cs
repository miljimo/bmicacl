



namespace BMIApplication.Models
{
    using System.ComponentModel;

    public class BasePropertyChangedEvent : INotifyPropertyChanged
    {

        private  object raisePropertyLocker = new object();
        /// <summary>
        /// The property change event handle
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
       

        /// <summary>
        ///  Raise property change event on C# Property.
        /// </summary>
        /// <param name="Name">The name of the property variable</param>
        protected void RaisePropertyChanged(string Name)
        {
            lock (raisePropertyLocker)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(Name));
                }
            }
        }
    }
}
