using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Service.User
{
    public class AdminModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public UserModel  User_Id { get; set; }
        public ProductModel Product_Id { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }

    }
}
