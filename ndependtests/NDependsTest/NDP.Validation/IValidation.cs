using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP.Validation
{
    public interface IValidation
    {
        string CheckPassword(string password);
        bool CheckUniquality(string phrase);
        void CheckEmailMask(string email);
        string CheckNIPLength(long nip);
        bool CheckAccountStatus(string accountName);
    }
}
