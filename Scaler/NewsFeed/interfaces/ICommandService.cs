using System;
using NewsFeed.model;

namespace NewsFeed.interfaces
{
	public interface ICommandService
	{
		public void CommandCall(User userContext);
	}
}

