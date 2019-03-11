using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIApplication.Models
{
    /// <summary>
    /// An interface class that all derive class have to inherit from
    /// to be able to create the body mass index
    /// </summary>
    public interface IBMICreator
    {
        /// <summary>
        /// Call to create a new body mass index for the user account number.
        /// </summary>
        /// <param name="AccountNumber"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        bool CreateIndex(AccountNumber UserAccountNumber, IBMDataType Data);
    }

    /// <summary>
    /// Updator interface that can be use to update a user account.
    /// </summary>
    public interface IBMIUpdator
    {
        bool UpdateIndex(AccountNumber UserAccountNumber, IBMDataType Data);
    }

    public interface IBMIAccessor
    {
        IBMDataType GetIndex(AccountNumber UserAccountNumber);
        IList<IBMDataType> GetAllIndex(AccountNumber UserAccountNumber);
    }

    public interface IBMIDeletion
    {
        bool DeleteIndex(AccountNumber UserAccountNumber);
    }
    /// <summary>
    ///  The base requirement contract for the IBMI database
    /// </summary>
    public interface IBMIRespository :
                     IBMICreator,
                     IBMIUpdator,
                     IBMIAccessor,
                     IBMIDeletion
    {

    }
}
