using System;
using NewsFeed.controller;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
	public class CommentOnFeedCommandService : ICommandService
	{
        CommentService commentService = new CommentService();
        public CommentOnFeedCommandService()
		{
		}

        public void CommandCall(User userContext)
        {
            Console.WriteLine("Please enter feed id for which you want to comment/reply");
            string feedIdString = Console.ReadLine();

            int feedId = Int32.Parse(feedIdString);
            Console.WriteLine("Please enter comment text:");
            string commentText = Console.ReadLine();

            commentService.CommentOnFeed(commentText, feedId, userContext);
            Console.WriteLine("Reply/Comment has been posted succesfully for the feed id:"+feedId);
        }
    }
}

