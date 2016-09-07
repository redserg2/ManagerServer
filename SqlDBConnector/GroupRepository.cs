using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;


namespace SqlDBConnector
{
    public class GroupRepository : RepositoryBase<ManagerDatabaseContainer>,
        IGroupRepository
    {

        public GroupRepository(ManagerDatabaseContainer _context)
            : base(_context)
        {
        }



        Group IGeneralRepository<Group>.FindById(object id)
        {
            throw new NotImplementedException();
        }

        List<Group> IGeneralRepository<Group>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IGeneralRepository<Group>.Save(Group Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
