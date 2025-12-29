using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaatBazar.Models.Entity
{
    [Table("orderMaster")]
    public class OrderMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; }

        public int? customerId { get; set; }

        [Required]
        public DateTime orderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal totalAmount { get; set; }

        [StringLength(50)]
        public string? paymentNaration { get; set; }
    }
}
