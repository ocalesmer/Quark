using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Customer.WalletTransactions")]
    public class WalletTransaction
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int TransactionTypeID { get; set; }
        public decimal TransactionFee { get; set; }
        public DateTime CreatedDate { get; set; }       
        public decimal CurrentBalance { get; set; }
        public decimal? AfterAprovedBalance { get; set; }
    }
}