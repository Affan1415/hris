using System.Globalization;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace hris.Models.Authenticaton.login
{
    public class loginmodel
    { 
        [Key]
        public int? employeeid { get; set; }
        public String? Email { get; set; }
        public String? PasswordHash { get; set; }
        public String? _type {  get; set; }
    }
}
