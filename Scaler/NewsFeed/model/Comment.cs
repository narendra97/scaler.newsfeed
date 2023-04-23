using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeed.model
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int Upvote { get; set; }
        public int Downvote { get; set; }
        public Comment? ChildComment { get; set; }
        public User CommentBy { get; set; }
    }
}