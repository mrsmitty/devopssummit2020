using System;

namespace devops_summit.Models
{
    public class CommitDto
    {
        public string By { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Url { get; set; }
    }
}