using System;
using NewsFeed.controller;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
	public class ShowNewsFeedCommandService : ICommandService
	{
        FeedService feedService = new FeedService();
        public ShowNewsFeedCommandService()
		{
		}

        public void CommandCall(User userContext)
        {
            List<Feed> newsFeeds = feedService.ShowNewsFeed(userContext);
            Console.WriteLine("=============");
            foreach (var feed in newsFeeds)
            {
                Console.WriteLine(feed.FeedItem);
                Console.WriteLine("--" + feed.FeedCreatedBy.FirstName);
                Console.WriteLine("--" + feed.FeedCreatedDate);
            }
            Console.WriteLine("=============");
        }
    }
}

