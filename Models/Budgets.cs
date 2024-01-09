using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetingApp.Models
{
    public class Budgets
    {
        [Key]
        public int BudgetID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        [StringLength(100)]
        public string BudgetName { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal TotalAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("UserID")]
        public virtual Users user { get; set; }

    }
    
}