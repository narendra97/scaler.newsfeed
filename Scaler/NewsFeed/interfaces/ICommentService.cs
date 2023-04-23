using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.model;

namespace NewsFeed.interfaces
{
    public interface ICommentService
    {
        public void CommentOnFeed(string commentText, int feedId, User user);
        public void CommentOnComment(string commentText, int commentId, User user);
        public void UpvoteComment(int commentId, User user);
        public void DownvoteComment(int commentId, User user);
    }
}