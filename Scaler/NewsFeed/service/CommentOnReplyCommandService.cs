using System;
using NewsFeed.controller;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
	public class CommentOnReplyCommandService : ICommandService
	{
        CommentService commentService = new CommentService();
        public CommentOnReplyCommandService()
		{
		}

        public void CommandCall(User userContext)
        {
            Console.WriteLine("Please enter comment id for which you want to comment/reply");
            string commentIdString = Console.ReadLine();

            int commentId = Int32.Parse(commentIdString);
            Console.WriteLine("Please enter comment text:");
            string commentText = Console.ReadLine();

            commentService.CommentOnComment(commentText, commentId, userContext);
            Console.WriteLine("Reply/Comment has been posted succesfully for the feed id:"+commentId);
        }
    }
}

