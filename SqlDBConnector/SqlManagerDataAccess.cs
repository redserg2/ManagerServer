using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerBL;
using System.Data.Sql;
using SqlDBConnector;
using DataModel;

namespace SqlManagerDataAccess
{

    public class SqlManagerDataAccess: IManagerDataAccess
    {
       
        public SqlManagerDataAccess()
        {
            using (var repostry = new RepositoryBase<ManagerDatabaseContainer>())
            {
                
                
                
            }
        }

        public DataAccessResult AddUser(User user_info)
        {
            throw new NotImplementedException();
        }
    }
}
