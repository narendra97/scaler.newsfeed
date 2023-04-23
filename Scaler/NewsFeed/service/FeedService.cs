using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
    public class FeedService : IFeedService
    {
        List<Feed> feeds = new List<Feed>();

        public void DownvoteFeed(int feedId, User user)
        {
            int index = feeds.FindIndex(f => f.FeedId == feedId);
            feeds[index].UpvoteCount++;
        }

        public void PostFeed(string feedItem, User user)
        {
            Feed feed = new Feed()
            {
                FeedItem = feedItem,
                FeedCreatedBy = user,
                FeedCreatedDate = DateTime.Now
            };
            feeds.Add(feed);
        }

        public List<Feed> ShowNewsFeed(User user)
        {
            return feeds;
        }

        public void UpvoteFeed(int feedId, User user)
        {
            int index = feeds.FindIndex(f => f.FeedId == feedId);
            feeds[index].UpvoteCount++;
        }
    }
}