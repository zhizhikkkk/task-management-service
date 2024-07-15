using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public int AssigneeId { get; set; }
        public int ProjectId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? CompletedAt { get; set; }

        [ForeignKey("AssigneeId")]
        public User Assignee { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
    }
}
