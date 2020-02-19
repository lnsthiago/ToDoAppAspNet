using System;
using TasksToDo.ApplicationCore.Enums;

namespace TasksToDo.ApplicationCore.Entity
{
    public class Task : Entity
    {
        public string Title { get; set; }

        public TaskStatus Status { get; set; }

        public DateTime Description { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public DateTime UpdateDate { get; set; }
        
        public DateTime DeleteDate { get; set; }
        
        public DateTime DoneDate { get; set; }
    }
}
