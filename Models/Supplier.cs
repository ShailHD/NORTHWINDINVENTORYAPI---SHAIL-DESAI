using System.ComponentModel.DataAnnotations;

namespace NorthwindInventoryAPI.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [StringLength(24)]
        public string Phone { get; set; }
    }
}
