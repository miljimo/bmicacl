

namespace BMIApplication.ViewModels
{
    using BMIApplication.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public class CreateUserAccountViewModel : BaseViewModel
    {
        private ICommand createUserAccount;
        private UserType user;


        public ICommand CreateUserAccountCommand
        {
            get
            {
                return createUserAccount ?? (createUserAccount = CreateCommand(OnCreateNewUserAccout));
            }
        }

        public UserType UserType
        {
            get
            {
                return user;
            }
        }

        private void OnCreateNewUserAccout(object obj)
        {
            
        }
    }
}
