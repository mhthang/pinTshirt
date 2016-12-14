using PinTshirt.Data.EntityFramework;
using PinTshirt.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinTshirt.Data.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private IDbFactory _dbFactory;
        private IPSDataContext _dbContext;


        public UnitOfWork()
        {
            this._dbFactory = new DbFactory();
            _dbContext = _dbFactory.Init();
        }

        public UnitOfWork(IPSDataContext context)
        {
            _dbContext = context;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
