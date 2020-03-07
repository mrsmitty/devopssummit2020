using System;
using System.Collections.Generic;

namespace devops_summit.Models
{
    public partial class CommitModel
    {
        public string Sha { get; set; }
        public string Node_Id { get; set; }
        public CommitChild Commit { get; set; }
        public string Url { get; set; }
        public string Html_Url { get; set; }
        public string Comments_Url { get; set; }
    }

    public partial class CommitChild
    {
        public Author Author { get; set; }
        public Author Committer { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        public long CommentCount { get; set; }
    }

    public partial class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}