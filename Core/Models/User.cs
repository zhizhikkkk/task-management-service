using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User
    {
        public Guid Id { get; set; } = new Guid();  

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.Now;
        public string Role { get; set; }
    }
}
