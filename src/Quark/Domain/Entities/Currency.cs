using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Common.Currencies")]
    public class Currency
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
    }
}