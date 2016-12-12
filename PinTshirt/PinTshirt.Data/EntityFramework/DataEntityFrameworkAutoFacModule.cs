using Autofac;

namespace PinTshirt.Data.EntityFramework
{
    public class DataEntityFrameworkAutoFacModule : Module
    {
        private string connStr;

        public DataEntityFrameworkAutoFacModule(string connString)
        {
            this.connStr = connString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new PSDataContext(this.connStr)).As<IPSDataContext>().InstancePerLifetimeScope();

            //builder.RegisterType<DbContextBase>().WithParameter(new TypedParameter(typeof(string), this.connStr)).As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<PSDataContext>().WithParameter(new TypedParameter(typeof(string), this.connStr)).As<PSDataContext>().InstancePerLifetimeScope();
        }
    }
}