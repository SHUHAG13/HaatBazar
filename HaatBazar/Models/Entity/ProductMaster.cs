using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaatBazar.Models.Entity
{
    [Table("productMaster")]
    public class ProductMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }

        [Required]
        public int childCategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string shortName { get; set; }=string.Empty;

        [Required]
        [StringLength(200)]
        public string fullName { get; set; }=string.Empty;

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal price { get; set; }

        [Required]
        [StringLength(1000)]
        public string description { get; set; }=string.Empty;

        [Required]
        [StringLength(50)]
        public string thumbnailImage { get; set; }=string.Empty;

        [Required]
        [StringLength(100)]
        public string productImage { get; set; }=string.Empty;

        [Required]
        [StringLength(50)]
        public string sku { get; set; }=string.Empty;
    }
}
