using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Service.User
{
    public class UserModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(6)]
        public string? Password { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(6)]
        public string?  ReenterThePassword { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(13)]
        public string? PhoneNumber { get; set; }
        [Required]
        [MaxLength(6)]
        [MinLength(4)]
        public string? ChekSMSCode { get; set; }
    }
}
