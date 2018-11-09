using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetStackUnderFlow.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsSolution { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
