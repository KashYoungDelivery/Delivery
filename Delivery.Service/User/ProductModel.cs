using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Service.User
{
    public class ProductModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? ProductName { get; set; }
        [Required]
        [StringLength(300)]
        public string? ProductDescription { get; set; }
        [Required]
        public string? ProductCategory { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
    }
}
