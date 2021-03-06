﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetStackUnderFlow.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public string UserId { get; set; }
        [NotMapped]
        public ICollection<Response> Responses { get; set; } = new List<Response>();
    }
}
