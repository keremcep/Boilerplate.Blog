using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boilerplate.BlogEntities
{
    [Table("AppTasks")]
    public class Task : Entity, IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLenth = 64 * 1024;

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }
        [StringLength(MaxDescriptionLenth)]
        public string Description { get; set; }
        public TaskState State { get; set; } 
        public DateTime CreationTime { get; set; }

        public Task()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }

        public Task(string title, string description = null)
            : this()
        {
            Title = title;
            Description = description;
        }
    }

    public enum TaskState: byte
    {
        Open = 0,
        Completed = 1
    }
}
