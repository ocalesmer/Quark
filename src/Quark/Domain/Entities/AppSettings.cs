using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Common.AppSettings")]
    public class AppSettings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string Placeholder { get; set; }
        public int Order { get; set; }
    }
}