using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriticalChain.Models
{
    public class TaskModel
    {
        public Int64 Id { get; set; }
        public int TaskId { get; set; }
        public bool IsStartTask { get; set; }
        public bool IsEndTask { get; set; }
        public string TaskContent { get; set; }
        public string TaskOwner { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public int PlannedLength { get; set; }
        public DateTime ActualStartDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public int ActualLength { get; set; }
        public int PreLinkedTaskId { get; set; }
        public int PostLinkedTaskId { get; set; }
        public string Status { get; set; }
    }
}
