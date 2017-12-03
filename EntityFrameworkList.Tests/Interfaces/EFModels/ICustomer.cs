namespace EntityFrameworkList.Tests.Interfaces.EFModels
{
    public interface ICustomer : IEFModel
    {
        int pintCUS_Customer { get; set; }
        string nvcCUS_Name { get; set; }
        string nvcCUS_Code { get; set; }
        bool bitCUS_IsActive { get; set; }
    }
}