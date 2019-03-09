
namespace BMIApplication.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    ///  A base class to the relay command
    ///  The class enabled the users to created a relay command to a command object.
    /// </summary>
    /// <typeparam name="T">The command paremeter type</typeparam>
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> oExecute = null;
        private readonly Predicate<T> oCanExecute = null;

        /// <summary>
        ///  constructor
        /// </summary>
        /// <param name="Execute">The action to called when the command is invoked.</param>
        public RelayCommand(Action<T> Execute)
            : this(Execute, p => true)
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Execute">The action to call  when the command is invoked.</param>
        /// <param name="CanExecute">The action to call to test if a command can be called.</param>
        public RelayCommand(Action<T> Execute, Predicate<T> CanExecute)
        {
            if (Execute == null)
            {
                throw new ArgumentNullException("Execute");
            }
            this.oExecute = Execute;
            this.oCanExecute = CanExecute;
        }

        /// <summary>
        /// Add and remove new command Predicate object from and to the command
        /// manager of the application.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (this.oCanExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        /// <summary>
        /// The function that will be called by the command manager
        /// </summary>
        /// <param name="parameter">The calling parameter of the command</param>
        public void Execute(object parameter)
        {
            this.oExecute.Invoke((T)parameter);
        }

        /// <summary>
        ///  The function will test if the command can be call or not.
        /// </summary>
        /// <param name="parameter">The command parameter</param>
        /// <returns> return true if the command can be called otherwise false.</returns>
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            bool CanStatus = true;
            if (oCanExecute != null)
            {
                CanStatus = oCanExecute.Invoke((T)parameter);
            }
            return CanStatus;
        }
    }
}
