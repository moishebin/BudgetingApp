using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetingApp.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public int BudgetID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal ButgetAmount { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal RemainingAmount { get; set; }

        [ForeignKey("ButgetID")]
        public virtual Budgets Butget { get; set; }
    }

}
