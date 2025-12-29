using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaatBazar.Models.Entity
{
    [Table("childCategoryMaster")]
    public class ChildCategoryMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int childCategoryId { get; set; }

        [Required]
        public int categoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string childCategoryName { get; set; }=string.Empty;
    }
}
