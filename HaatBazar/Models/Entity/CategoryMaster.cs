using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaatBazar.Models.Entity
{
    [Table("categoryMaster")]
    public class CategoryMaster
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string categoryName { get; set; }=string.Empty;

        [Required]
        [StringLength(100)]
        public string imageName { get; set; }= string.Empty;
    }
}
