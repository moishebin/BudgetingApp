using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetingApp.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionID { get; set; }
        [Required]
        public int CategoryID { get; set; }
        public DateTime TransactionDate { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal TransactionAmount { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }

        [ForeignKey("CatogoryID")]
        public virtual Categories Category { get; set; }
    }
}
