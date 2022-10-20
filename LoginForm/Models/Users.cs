using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginForm.Models
{
    public class Users
    {
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastLoginOn { get; set; }
    }
}
