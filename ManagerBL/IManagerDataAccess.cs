using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManagerBL
{
    public enum DataAccessResult
    {
        SUCCESS,
        EXISTING_RECORD,
        INVALID_ARGUMENTS,
        CONNECTION_ERROR
    }

    public interface IManagerDataAccess
    {
        DataAccessResult AddUser(UserInfo user_info);

    }
}
