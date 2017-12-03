namespace EntityFrameworkList.Tests.EFModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

        public class BankTransaction
    {
        public string EntityName => "BankTransaction";

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RecordId { get; set; }
        public string SerialNumber { get; set; }
        public string TransactionType { get; set; }
        public DateTime IssueDate { get; set; }
        public string BankCode { get; set; }
        public decimal Amount { get; set; }
        public string PayeeCode { get; set; }
        public string Customer { get; set; }
        public string BatchNumber { get; set; }
        public string Status { get; set; }
        public DateTime RemitDate { get; set; }
        public DateTime ClearedDate { get; set; }
        public DateTime ReconciledDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string ReplacedBySerialNumber { get; set; }
        public string ReplacedByRSN { get; set; }
        public string ImageBatchId { get; set; }
        public string ImageOpticalVolume { get; set; }
        public string PayeeContact { get; set; }
        public string PayeeCompany { get; set; }
        public string PayeeStreet { get; set; }
        public string PayeeCity { get; set; }
        public string PayeeStateOrProvince { get; set; }
        public string PayeePostalCode { get; set; }
        public string PayeeCountry { get; set; }
        public string PayeeERemit { get; set; }
        public string Memo { get; set; }
        public string Comments { get; set; }
        public string EFTNumber { get; set; }
        public string EFTRouting { get; set; }
        public string EFTAccount { get; set; }
        public string EFTBatch { get; set; }
    }
}