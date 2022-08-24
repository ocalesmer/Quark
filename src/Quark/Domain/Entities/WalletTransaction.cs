using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Customer.WalletTransactions")]
    public class WalletTransaction
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int TransactionTypeID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public int CurrencyID { get; set; }
        public decimal BalanceBefore { get; set; }
        public decimal BalanceAfter { get; set; }
    }
}