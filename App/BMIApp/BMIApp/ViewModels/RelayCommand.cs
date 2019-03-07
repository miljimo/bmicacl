using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace UI.ViewModel
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T>       oExecute     =  null;
        private readonly Predicate<T>    oCanExecute  = null;

        public RelayCommand(Action<T> Execute)
            : this(Execute, p => true)
        {
        }

        public RelayCommand(Action<T> Execute, Predicate<T> CanExecute)
        {
            if (Execute == null)
            {
                throw new ArgumentNullException("Execute");
            }
            this.oExecute    = Execute;
            this.oCanExecute = CanExecute;
        }

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

        public static void NotifyCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        public void Execute(object parameter)
        {
            this.oExecute.Invoke((T)parameter);
        }

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
