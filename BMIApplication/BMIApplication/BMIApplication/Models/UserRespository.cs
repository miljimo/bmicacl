

namespace BMIApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    /// <summary>
    /// Front Controller object .
    /// This class expose all the group interface function about a user account management.
    /// Easy to move group of object arround.
    /// </summary>
    class UserRepository : IUserRespository
    {

        private ICreateUserAccount         createUserAccount;
        private IUpdateUserAccount         updateUserAccount;
        private IDeleteUserAccount         deleteUserAccount;
        private IGetUserAccountInformation getUserAccount;


        public UserRepository()
        {
            createUserAccount = null;
            updateUserAccount = null;
            deleteUserAccount = null;
            deleteUserAccount = null;
            getUserAccount    = null;
        }

        /// <summary>
        /// Check if this user account can be created or not.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool CanCreateAccount(UserType user)
        {
            bool Status = false;

            if(createUserAccount != null)
            {
                Status  = createUserAccount.CanCreateAccount(user);
            }

            return Status;
        }

        /// <summary>
        /// The function will be use to check if the user account can be delete or not.
        /// </summary>
        /// <returns></returns>
        public bool CanDeleteAccount(AccountNumber accountNumber)
        {
            bool status = false;

            if (deleteUserAccount != null)
                status = deleteUserAccount.CanDeleteAccount(accountNumber);
            return status;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CanUpdateAccount(AccountNumber accountNumber)
        {
            bool status = false;
            if (updateUserAccount != null)
                status = updateUserAccount.CanUpdateAccount(accountNumber);
            return status;
        }

        /// <summary>
        /// The function create a new user account information
        /// </summary>
        /// <param name="user"></param>
        /// <returns>return the new account number.
        /// user need this account number to be about to login into their account.
        /// </returns>
        public AccountNumber CreateAccount(UserType user)
        {
            AccountNumber AcctNumber = AccountNumber.Invalid;

            if(createUserAccount != null)
            {

                AcctNumber  =  createUserAccount.CreateAccount(user);
               
            }
            return AcctNumber;
        }

        /// <summary>
        /// The function will be use to delete a user account.
        /// </summary>
        /// <param name="AccountNumber"></param>
        /// <returns></returns>
        public bool DeleteAccount(AccountNumber AccountNumber)
        {
            bool Deleted = false;

            if (deleteUserAccount != null)
            {
               Deleted  =   deleteUserAccount.DeleteAccount(AccountNumber);
            }
            return Deleted;
        }

        /// <summary>
        /// The function will get the current user information.
        /// </summary>
        /// <param name="AccountNumber"></param>
        /// <returns></returns>
        public UserType GetUser(AccountNumber AccountNumber)
        {
            UserType User = UserType.Empty;

            if (getUserAccount != null)
                User = getUserAccount.GetUser(AccountNumber);
            return User;
        }

        /// <summary>
        /// The function will update the current user account 
        /// sing the give informations.
        /// </summary>
        /// <param name="AccountNumber"></param>
        /// <param name="User"></param>
        /// <returns></returns>
        public bool UpdateAccount(AccountNumber AccountNumber, UserType User)
        {
            bool Updated = false;
            if(updateUserAccount != null)
            {
               Updated  =   updateUserAccount.UpdateAccount(AccountNumber , User);
            }
            return Updated;
        }
    }

}
