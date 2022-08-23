using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("User.Roles")]
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }
    }
}