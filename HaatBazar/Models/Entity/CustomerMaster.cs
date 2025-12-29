using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaatBazar.Models.Entity
{
    [Table("customerMaster")]
    public class CustomerMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int customerId { get; set; }

        [Required]
        [StringLength(50)]
        public string customerName { get; set; }=string.Empty;

        [Required]
        [StringLength(50)]
        public string mobileNo { get; set; }=string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string email { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string city { get; set; }=string.Empty;

        [Required]
        [StringLength(100)]
        public string address { get; set; }=string.Empty;

        [Required]
        [StringLength(6)]
        public string pinCode { get; set; }=string.Empty;
    }
}
