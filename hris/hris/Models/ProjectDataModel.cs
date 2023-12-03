using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ProjectData
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int ProjectID { get; set; }

	[Required]
	[MaxLength]
	public string Name { get; set; }

	public DateTime? Deadline { get; set; }

	[MaxLength]
	public string Lead { get; set; }

	public decimal? Price { get; set; }

	[MaxLength]
	public string AssignedEmployeeName { get; set; }
}
