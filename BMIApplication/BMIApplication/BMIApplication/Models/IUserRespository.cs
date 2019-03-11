

namespace BMIApplication.Models
{
    using BMIApplication.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public enum UserAccountState
    {
        InvalidAccount = -1,
        ActiveAccount,
        BlockAccount
    }

    public enum GenderType
    {
        UnDisclosed,
        Male,
        Female
    };

    /// <summary>
    ///  
    /// </summary>
    public class UserCredential
    {
        string Username { get; set; }
        string Password { get; set; }
        bool   Valid { get; }
        UserAccountState AccountState { get; set;}
    }

    /// <summary>
    ///  The account number of the users.
    /// </summary>
    public class AccountNumber
    {
        private string accountNumber;

        /// <summary>
        /// An invalid account number which is an empty string object.
        /// </summary>
        public static AccountNumber Invalid = new AccountNumber("");

        AccountNumber(string accountId)
        {
            accountNumber = accountId;

        }

        /// <summary>
        /// Get and set the account number of the users.
        /// </summary>
        public string AccountNUmber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                if (accountNumber != value)
                {
                    accountNumber = value;

                }
            }
        }
        /// <summary>
        /// A flag to check if the account number is valid or not.
        /// </summary>
        public bool Valid
        {
            get
            {
                return !String.IsNullOrEmpty(accountNumber.Trim());
            }
        }
    }


    /// <summary>
    /// The user object.
    /// </summary>
    public class UserType
    {
        public static UserType Empty = new UserType();

        /// <summary>
        /// Default constructor.
        /// </summary>
        public UserType()
        {
            FirstName      = "";
            LastName       = "";
            Gender         = GenderType.UnDisclosed;
            UserCredential = null;
        }
       
        public string     Title;
        public string     FirstName;
        public string     LastName;
        public GenderType Gender;

        public UserCredential UserCredential { get; set; }
    }


    /// <summary>
    ///  An interface to creating the user account.
    /// </summary>
    public  interface ICreateUserAccount
    {
        /// <summary>
        /// he function is use to create a user account.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        AccountNumber CreateAccount(UserType user);
        /// <summary>
        /// The function will check if the account can be create or not.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool              CanCreateAccount(UserType user);
    }

    /// <summary>
    /// The function is use to update the user account.
    /// </summary>
    public interface IUpdateUserAccount
    {
        /// <summary>
        /// The function should be called to update the user account.
        /// </summary>
        /// <param name="AccountNumber"></param>
        /// <param name="User"></param>
        /// <returns></returns>
        bool UpdateAccount(AccountNumber AccountNumber, UserType User);

        /// <summary>
        ///  The function will be use to check if the account should be update or not.
        /// </summary>
        /// <returns></returns>
        bool CanUpdateAccount(AccountNumber AccountNumber);
    }

    /// <summary>
    /// The interface to delete the user account.
    /// </summary>
    public interface IDeleteUserAccount
    {
        /// <summary>
        ///  The function is invoke to delete the user account.
        /// </summary>
        /// <param name="AccountNumber"></param>
        /// <returns></returns>
        bool DeleteAccount(AccountNumber AccountNumber);
        /// <summary>
        ///  The function check if the account can be deleted or not.
        /// </summary>
        /// <returns></returns>
        bool CanDeleteAccount(AccountNumber AccountNumber);
    }

    /// <summary>
    /// Interface that is use to count the user account that have be created.
    /// </summary>
    public interface IUserAccountCounter
    {
        /// <summary>
        /// Count the user account;
        /// </summary>
        /// <returns></returns>
        int Count();
    }

    public interface IVerifyUserAccount
    {
        /// <summary>
        /// The function will be use to check if the user 
        /// exists or not.
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        bool Verify(UserType User);
    }


    /// <summary>
    ///  Get the current user information.
    /// </summary>
    public interface IGetUserAccountInformation
    {
       UserType   GetUser(AccountNumber AccountNumber);
    }


    public interface IUserAuthentication
    {
        /// <summary>
        ///  Check if the user credential is valid or not.
        /// </summary>
        /// <param name="userCredential"></param>
        /// <returns></returns>
        bool Authenticate(UserCredential userCredential);
    
     
    }

    /// <summary>
    ///  An interface to a validation object or value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IValueValidator<T>
    {
        bool validate(T value);
    }

    /// <summary>
    ///  The user Account Repository.
    ///  //The class interface is use to create and load new users
    /// </summary>
    public interface IUserRespository : ICreateUserAccount ,
                                        IUpdateUserAccount ,
                                        IDeleteUserAccount,
                                        IGetUserAccountInformation
    {


    }

   
    public  struct IBMDataType
    {
        public IBMDataType(AccountNumber userAccountNumber)
        {
            UserAccountAccount = userAccountNumber;
            Height = 0.0;
            Mass = 0.0;
            AccountNumber = AccountNumber.Invalid;
            DateCreated   = DateTime.Now;
        }

        public double   Height { get; set; }
        public double   Mass   { get; set; }
        public DateTime DateCreated { get; set; }
        public  AccountNumber AccountNumber { get; set; }
        public  AccountNumber UserAccountAccount { get;}
    }

  


}
