using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace SqlDBConnector
{
    public class DataUOW : IDataUOW  
    {
        private ManagerDatabaseContainer _context=new ManagerDatabaseContainer();
        private IUserRepository _Users;
        private IGroupRepository _Group;

        public IUserRepository Users
        {
            get
            {
                if (this._Users == null)
                {

                    this._Users = new UserRepository(_context);

                }
                return _Users;
            }
        }

        public IGroupRepository Groups
        {
            get
            {
                if (this._Group == null)
                {
                    this._Group=new GroupRepository(_context);
                }
                return _Group;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
