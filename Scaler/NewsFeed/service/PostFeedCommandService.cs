using System;
using NewsFeed.controller;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
	public class PostFeedCommandService : ICommandService
	{
        FeedService feedService = new FeedService();
        public PostFeedCommandService()
		{
		}

        public void CommandCall(User userContext)
        {
            Console.WriteLine("Please enter news feed text:");
            string newsFeedText = Console.ReadLine();

            feedService.PostFeed(newsFeedText, userContext);
            Console.WriteLine("News has been posted succesfully");
        }
    }
}

