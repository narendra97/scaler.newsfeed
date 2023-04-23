using System;
using NewsFeed.controller;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
	public class VoteNewsFeedCommandService : ICommandService
	{
        FeedService feedService = new FeedService();
        public VoteNewsFeedCommandService()
		{
		}

        public void CommandCall(User userContext)
        {
            Console.WriteLine("Please enter feed id for which you want to vote");
            string feedIdString = Console.ReadLine();
            int feedId = Int32.Parse(feedIdString);

            Console.WriteLine("Please enter 'U' for upvote and 'D' for downvote");
            string vote = Console.ReadLine();
            if (vote.ToLowerInvariant() == "u")
            {
                feedService.UpvoteFeed(feedId, userContext);
            }
            else if (vote.ToLowerInvariant() == "d")
            {
                feedService.DownvoteFeed(feedId, userContext);
            }
            else
                Console.WriteLine("Invalid argument");
        }
    }
}

