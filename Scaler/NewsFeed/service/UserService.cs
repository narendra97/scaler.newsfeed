using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.interfaces;
using NewsFeed.model;

namespace NewsFeed.service
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>();

        public void FollowUser(User user, User follower)
        {
            throw new NotImplementedException();
        }

        public string HashPassword(string password)
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password)
        {
            int index = users.FindIndex(u =>
            {
                return (u.Email.ToLowerInvariant() == username && u.password == password);
            });
            if (index >= 0)
                return users[index];
            return null;
        }

        public User Signup(User user)
        {
            user.UserId = users.Count + 1;
            users.Add(user);
            return user;
        }
    }
}