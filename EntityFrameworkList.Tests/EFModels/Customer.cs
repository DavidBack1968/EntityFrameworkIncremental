namespace EntityFrameworkList.Tests.EFModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Interfaces.EFModels;

    public class Customer : ICustomer
    {
        public string EntityName => "Customer";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pintCUS_Customer { get; set; }
        public string nvcCUS_Name { get; set; }
        public string nvcCUS_Code { get; set; }
        public bool bitCUS_IsActive { get; set; }
    }
}