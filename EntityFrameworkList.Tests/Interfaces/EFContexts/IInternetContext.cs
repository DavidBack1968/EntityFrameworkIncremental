namespace EntityFrameworkList.Tests.Interfaces.EFContexts
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Tests.EFModels;

    public interface IInternetContext : IDisposable
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<DisplayItem> DisplayItems { get; set; }
        DbSet<DomoTransformData> TransformData { get; set; }
        DbSet<FreightTransaction> FreightTransactions { get; set; }
        DbSet<ReportTemplate> ReportTemplates { get; set; }
        Database Database { get; }

        IQueryable<T> EntitySetAsQueryable<T>();
    }
}