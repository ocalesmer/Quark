using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("User.SecurityClaims")]
    [Keyless]
    public class SecurityClaim
    {
        public string Key { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
    }
}