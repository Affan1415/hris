using System.ComponentModel.DataAnnotations;

namespace hris.Models
{
    public class EmployeeData
    {
        [Key]
        public int EmployeeID { get; set; }

        public String ? _type { get; set; }

        public String? _Name { get; set; }

        public String? Designation { get; set; }

        public String? ContactNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? JoiningDate { get; set; }

        public String? CurrentAddress { get; set; }

        public String ? Email { get; set; }

        public String ? Gender { get; set; }

        public float ? Salary { get; set; }
    }
}
