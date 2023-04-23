using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeed.model
{
    public class UserFollower
    {
        public int UserFollowerId { get; set; }
        public User? User { get; set; }
        public User? Follower { get; set; }
    }
}