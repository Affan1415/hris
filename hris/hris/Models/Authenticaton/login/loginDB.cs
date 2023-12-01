using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace hris.Models.Authenticaton.login
{
    public class loginDB : DbContext
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int type { get; set; }

    }
}
