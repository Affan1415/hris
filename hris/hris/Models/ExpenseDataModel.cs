using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hris.Models
{
	public class ExpenseDataModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(255)]
		public string Item { get; set; }

		[MaxLength(255)]
		public string PurchaseFrom { get; set; }

		public DateTime? PurchaseDate { get; set; }

		[MaxLength(255)]
		public string PurchaseBy { get; set; }

		[Required]
		[Column(TypeName = "decimal(10,2)")]
		public decimal Amount { get; set; }

		[MaxLength(255)]
		public string PaidBy { get; set; }
	}
}
