using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.model;

namespace NewsFeed.interfaces
{
    public interface IUserService
    {
        public User Signup(User user);

        public User Login(string username, string password);

        public string HashPassword(string password);

        public void FollowUser(User user, User follower);
    }
}