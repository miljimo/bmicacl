

namespace BMIApplication.ViewModels
{
    using BMIApplication.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;

    public class BaseViewModel :BasePropertyChangedEvent
    {


        /// <summary>
        ///  Get a resources by the resource id.
        /// </summary>
        /// <typeparam name="T">The current object type to cast the resource to</typeparam>
        /// <param name="ResKey">The resource id must be a string</param>
        /// <returns>Return the resource object casted to T</returns>
        public T Localize<T>(string ResKey)
        {
            return (T)Application.Current.TryFindResource(ResKey);
        }

        /// <summary>
        ///  Get a resources by the resource id.
        /// </summary>
        /// <typeparam name="T">The current object type to cast the resource to</typeparam>
        /// <param name="ResKey">The resource id must be a string</param>
        /// <param name="DefaultValue">The default value to return if the resources is not found.</param>
        /// <returns>Return the resource object casted to T</returns>
        public T Localize<T>(string ResKey, T DefaultValue)
        {
            object Res = Application.Current.TryFindResource(ResKey);
            if (Res == null)
                Res = DefaultValue;
            return (T)Res;
        }

        #region Create New Command Methods
        /// <summary>
        ///  Create a relay command to a command objects like buttons e.t.c
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Action"></param>
        /// <param name="Predicate"></param>
        /// <returns></returns>
        protected virtual ICommand CreateCommand<T>(Action<T> Action, Predicate<T> Predicate = null)
        {
            return new RelayCommand<T>(Action, Predicate);

        }
        /// <summary>
        ///  Create a relay command to a command objects like buttons e.t.c
        /// </summary>
        /// <param name="Action"></param>
        /// <param name="Predicate"></param>
        /// <returns></returns>
        protected virtual ICommand CreateCommand(Action<object> Action, Predicate<object> Predicate = null)
        {
            return CreateCommand<object>(Action, Predicate);
        }
        #endregion

       

    }
}