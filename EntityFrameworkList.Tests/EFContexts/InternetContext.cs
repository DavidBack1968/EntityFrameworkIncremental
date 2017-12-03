namespace EntityFrameworkList.Tests.EFContexts
{
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    using EFModels;
    using EFModels.Mapping;
    using Interfaces.EFContexts;

    public class InternetContext : DbContext, IInternetContext
    {
        static InternetContext()
        {
            Database.SetInitializer<InternetContext>(null);
        }

        public InternetContext(string conn) : base(conn)
        {
            Database.CommandTimeout = 5000;
            Database.SetInitializer<InternetContext>(null);
            ObjectContext objectContext = ((IObjectContextAdapter)this).ObjectContext;
            objectContext.CommandTimeout = 5000;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DisplayItem> DisplayItems { get; set; }
        public DbSet<DomoTransformData> TransformData { get; set; }
        public DbSet<FreightTransaction> FreightTransactions { get; set; }
        public DbSet<ReportTemplate> ReportTemplates { get; set; }

        public IQueryable<T> EntitySetAsQueryable<T>()
        {
            string typename = typeof(T).Name.ToUpperInvariant();
            switch (typename)
            {
                case "CUSTOMER":
                    return Customers as IQueryable<T>;
                case "DISPLAYITEM":
                    return DisplayItems as IQueryable<T>;
                case "FREIGHTTRANSACTION":
                    return FreightTransactions as IQueryable<T>;
                case "REPORTTEMPLATE":
                    return ReportTemplates as IQueryable<T>;
                default:
                    return null;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DisplayItemMap());
            modelBuilder.Configurations.Add(new DomoTransformDataMap());
            modelBuilder.Configurations.Add(new FreightTransactionMap());
            modelBuilder.Configurations.Add(new ReportTemplateMap());
        }
    }
}
