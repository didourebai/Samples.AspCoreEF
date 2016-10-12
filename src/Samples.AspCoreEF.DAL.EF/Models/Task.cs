using System;

namespace Samples.AspCoreEF.DAL.EF.Models
{
    public class Task
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }

        public virtual Person AssignedTo { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Task()
        {
            CreationTime = DateTime.UtcNow;
            State = TaskState.Open;
        }

    }

    public enum TaskState : byte
    {
        /// <summary>
        /// The task is Open.
        /// </summary>
        Open = 0,
        /// <summary>
        /// The task is active.
        /// </summary>
        Active = 1,

        /// <summary>
        /// The task is completed.
        /// </summary>
        Completed = 2,

        /// <summary>
        /// The task is closed.
        /// </summary>
        Closed = 3
    }
}

