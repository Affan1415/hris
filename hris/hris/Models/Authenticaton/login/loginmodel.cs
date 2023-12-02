using System.Globalization;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hris.Models.Authenticaton.login
{
    public class loginmodel
    { 
        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int employeeid { get; set; }
        public String? Email { get; set; }
        public String? PasswordHash { get; set; }
        public String? _type {  get; set; }
    }
}
