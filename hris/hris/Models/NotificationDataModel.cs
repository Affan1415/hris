using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hris.Models
{
	public class NotificationDataModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MaxLength(255)]
		public string? Notify { get; set; }

		[Required]
		public DateTime Time { get; set; }
	}
}
