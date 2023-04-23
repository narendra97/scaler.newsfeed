using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsFeed.interfaces;
using NewsFeed.service;

namespace NewsFeed.controller
{
    public class FeedController
    {
        IFeedService feedService = new FeedService();
    }
}