
namespace BMIApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRespositoryManager
    {
        UserCredential      UserCredential       { get; }
        IUserRespository    UserRespository      { get; }
    }
}
