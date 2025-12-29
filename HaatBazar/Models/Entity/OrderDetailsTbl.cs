using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaatBazar.Models.Entity
{
    [Table("orderDetailsTbl")]
    public class OrderDetailsTbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderDetailId { get; set; }

        [Required]
        public int orderId { get; set; }

        [Required]
        public int productId { get; set; }

        [Required]
        public int quantity { get; set; }
    }
}
