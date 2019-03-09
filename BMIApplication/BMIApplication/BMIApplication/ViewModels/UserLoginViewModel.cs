

namespace BMIApplication.ViewModels
{
    using BMIApplication.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;

    public class UserLoginViewModel : BaseViewModel
    {
        private ICommand createUserAccountLinkCommand;
        private ICommand accessUserAccountCommand;
        private string username;
        private string errorMessage;

        /// <summary>
        /// Constructor.
        /// </summary>
        public UserLoginViewModel()
        {
            errorMessage = "All field required.";
            createUserAccountLinkCommand = null;
            accessUserAccountCommand     = null;
        }
        
        /// <summary>
        /// The Expose View Property.
        /// </summary>
        public string ErrorMessage {

            get
            {
                return errorMessage;
            }
            set
            {
                if(!errorMessage.Equals(value))
                {
                    errorMessage = value;
                    RaisePropertyChanged(nameof(ErrorMessage));
                }
            }
        }

        /// <summary>
        /// Navidate to the account page command.
        /// </summary>
        public ICommand CreateAccountLinkCommand
        {
            get
            {
                return (createUserAccountLinkCommand == null) ? 
                         createUserAccountLinkCommand = CreateCommand(OnShowCreateAccountScreen) : createUserAccountLinkCommand;
            }
        }


        public ICommand AccessUserAccountCommand
        {
            get
            {
               return  accessUserAccountCommand ?? (accessUserAccountCommand = CreateCommand(OnAccessAccount));
            }
        }

        private void OnAccessAccount(object obj)
        {

          

        }

        private void OnShowCreateAccountScreen(object obj)
        {
            this.NavigateTo(MainPageType.RegisterPageType);
        }


        /// <summary>
        /// This is a way to get the view model parent.
        /// </summary>
        /// <param name="PageType"></param>
        public void NavigateTo(MainPageType PageType)
        {
            if (MainWindowPageConverter.Instance != null)
            {
                MainModelView ViewModel = Application.Current.MainWindow.DataContext as MainModelView;

                if (ViewModel != null)
                {
                    ViewModel.PageType = PageType;
                }
            }
        }
        /// <summary>
        /// Get the username
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if(username != value)
                {
                    username = value;
                    RaisePropertyChanged(nameof(Username));
                }
            }
        }
    }
}
