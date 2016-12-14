using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinTshirt.Data.EntityFramework
{
    public class DbFactory: Disposable, IDbFactory
    {
        private IPSDataContext _context;
        public DbFactory(IPSDataContext context)
        {
            this._context = context;
        }

        public DbFactory()
        {

        }

        public IPSDataContext Init()
        {
            return _context ?? (_context = new PSDataContext(PinTshirt.Commons.Constants.ENTITY_FRAMEWORK_CONNECTION_STRING));
        }


        protected override void DisposeCore()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}
