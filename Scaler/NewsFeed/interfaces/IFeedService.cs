using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.model;

namespace NewsFeed.interfaces
{
    public interface IFeedService
    {
        public void PostFeed(string feedItem, User user);
        public void UpvoteFeed(int feedId, User user);
        public void DownvoteFeed(int feedId, User user);
        public List<Feed> ShowNewsFeed(User user);
    }
}