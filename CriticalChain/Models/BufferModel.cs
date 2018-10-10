using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriticalChain.Models
{
    public class BufferModel
    {
        public Int64 Id { get; set; }
        public int BufferId { get; set; }
        public string BufferType { get; set; }
        public int BufferLength { get; set; }
        public int BufferHeadTaskId { get; set; }
        public int BufferTailTaskId { get; set; }
    }
}
