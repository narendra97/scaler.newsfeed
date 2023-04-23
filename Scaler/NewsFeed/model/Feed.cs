using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeed.model
{
    public class Feed
    {
        public int FeedId { get; set; }
        public string FeedItem { get; set; }
        public DateTime FeedCreatedDate { get; set; }
        public int UpvoteCount { get; set; }
        public int DoenvoteCount { get; set; }
        public List<Comment> Comments { get; set; }
        public User FeedCreatedBy { get; set; }
    }
}