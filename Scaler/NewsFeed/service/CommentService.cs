using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
    public class CommentService : ICommentService
    {
        List<Comment> comments = new List<Comment>();

        public void CommentOnComment(string commentText, int commentId, User user)
        {
            Comment newChildComment = new Comment
            {
                CommentId = comments.Count + 1,
                CommentText = commentText,
                CommentBy = user,
                CommentDate = DateTime.Now
            };
            int index = comments.FindIndex(c => c.CommentId == commentId);
            comments[index].ChildComment = newChildComment;
        }

        public void CommentOnFeed(string commentText, int feedId, User user)
        {
            Comment newComment = new Comment
            {
                CommentId = comments.Count+1,
                CommentText = commentText,
                CommentBy = user,
                CommentDate = DateTime.Now
            };
            comments.Add(newComment);
        }

        public void DownvoteComment(int commentId, User user)
        {
            int index = comments.FindIndex(c => c.CommentId == commentId);
            comments[index].Downvote++;
        }

        public void UpvoteComment(int commentId, User user)
        {
            int index = comments.FindIndex(c => c.CommentId == commentId);
            comments[index].Upvote++;
        }
    }
}