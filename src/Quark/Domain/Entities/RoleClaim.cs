using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("User.RoleClaims")]
    [Keyless]
    public class RoleClaim
    {
        public int RoleID { get; set; }
        public string Key { get; set; }
    }
}