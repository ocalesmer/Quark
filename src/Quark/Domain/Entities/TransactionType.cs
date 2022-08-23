using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Common.TransactionTypes")]
    public class TransactionType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
