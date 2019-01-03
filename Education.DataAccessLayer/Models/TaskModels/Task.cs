using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DataAccessLayer.Models.TaskModels
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public StatusOfTask StatusOfTask{ get; set; } = StatusOfTask.Planned;
        public bool IsCompleted { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public bool IsFinished { get; set; } = false;
        public int UserId { get; set; }
        public virtual UserModels.User User { get; set; }
    }
}
