using System;
using NewsFeed.controller;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
	public class VoteCommentCommandService : ICommandService
	{
        CommentService commentService = new CommentService();
        public VoteCommentCommandService()
		{
		}

        public void CommandCall(User userContext)
        {
            Console.WriteLine("Please enter comment id for which you want to vote");
            string commentIdString = Console.ReadLine();
            int commentId = Int32.Parse(commentIdString);

            Console.WriteLine("Please enter 'U' for upvote and 'D' for downvote");
            string vote = Console.ReadLine();
            if (vote.ToLowerInvariant() == "u")
            {
                commentService.UpvoteComment(commentId, userContext);
            }
            else if (vote.ToLowerInvariant() == "d")
            {
                commentService.DownvoteComment(commentId, userContext);
            }
            else
                Console.WriteLine("Invalid argument");
        }
    }
}

