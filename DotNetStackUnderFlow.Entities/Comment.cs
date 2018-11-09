using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetStackUnderFlow.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int ResponseId { get; set; }
        public string Body { get; set; }
    }
}
