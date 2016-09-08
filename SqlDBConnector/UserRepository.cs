using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace SqlDBConnector
{
    public class UserRepository : GenericRepository<ManagerDatabaseContext,User>,
        IUserRepository
        
    {
        public UserRepository(ManagerDatabaseContext context):base(context)
        {
            
        }

        public User FindById(object id)
        {
           
            throw new NotImplementedException();
        }

        public User FindByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            var list = Get();
            return list.ToList();
        }

        public void Save(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
