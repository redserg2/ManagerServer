using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace SqlDBConnector
{
    class MembershipRepository:GenericRepository<ManagerDatabaseContext,MemberShip> ,
        IMembershipRepository
    {
        public MembershipRepository(ManagerDatabaseContext context)
            : base(context)
        {
        }

    }
}
