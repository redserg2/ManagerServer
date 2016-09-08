using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;


namespace SqlDBConnector
{
    public class GroupRepository : GenericRepository<ManagerDatabaseContext,Group>,
        IGroupRepository
    {

        public GroupRepository(ManagerDatabaseContext _context)
            : base(_context)
        {
        }


        public new bool Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
