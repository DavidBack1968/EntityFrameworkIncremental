namespace EntityFrameworkList.Tests.EFModels.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customers");
        }
    }
}