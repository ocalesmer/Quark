using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Customer.Customers")]
    public class Customer
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public bool IsEnabled { get; set; }
        public string Address { get; set; }
        public string MobileDevicePushID { get; set; }
        public string SmsCode { get; set; }
        public DateTime? SmsCodeExpireDate { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpireDate { get; set; }
        [NotMapped]
        public string FullName { get { return $"{Firstname} {Lastname}"; } }
    }
}