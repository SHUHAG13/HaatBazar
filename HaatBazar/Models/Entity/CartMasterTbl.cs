using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaatBazar.Models.Entity
{
    [Table("cartMasterTbl")]
    public class CartMasterTbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cartId { get; set; }

        [Required]
        public int customerId { get; set; }

        [Required]
        public int productId { get; set; }

        [Required]
        public int quantity { get; set; }

        [Required]
        public DateTime addedDate { get; set; }

        [Required]
        public DateTime modifiedDate { get; set; }
    }
}
