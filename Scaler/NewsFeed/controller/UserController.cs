using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.interfaces;
using NewsFeed.model;
using NewsFeed.service;

namespace NewsFeed.controller
{
    public class UserController
    {
        IUserService userService = new UserService();
        public User Signup(User user)
        {
            return userService.Signup(user);
        }
        public User Login(string email, string password)
        {
            return userService.Login(email, password);
        }
    }
}