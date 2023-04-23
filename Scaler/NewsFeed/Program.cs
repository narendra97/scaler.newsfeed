// See https://aka.ms/new-console-template for more information
using NewsFeed.controller;
using NewsFeed.interfaces;
using NewsFeed.model;
using NewsFeed.service;

IUserService userService = new UserService();
Console.WriteLine("Welcome to News Feed application!");
Console.WriteLine("Please use below command to use News feed application features!");
Console.WriteLine("'signup' - For user registration");
Console.WriteLine("'login' - For already exiting user");
Console.WriteLine("'post_feed' - Add news to feed");
Console.WriteLine("'show_feeds' - Show news feed");
Console.WriteLine("'vote_feed' - Vote news feed");
Console.WriteLine("'reply_feed' - Reply on news feed");
Console.WriteLine("'vote_reply' - Vote on reply");

string userCommand = Console.ReadLine();

ICommandService commandService;

User userContext = new User();

List<User> users = new List<User>();

if (userCommand == Command.signup.ToString())
{
    Console.WriteLine("Please provide below information:");
    Console.WriteLine("First name:");
    string firstName = Console.ReadLine();
    Console.WriteLine("Last name:");
    string lastName = Console.ReadLine();
    Console.WriteLine("Email:");
    string email = Console.ReadLine();
    Console.WriteLine("Phone number:");
    string phoneNumber = Console.ReadLine();
    Console.WriteLine("Password:");
    string password = Console.ReadLine();
    User newUser = new User
    {
        FirstName = firstName,
        LastName = lastName,
        PhoneNumber = phoneNumber,
        Email = email,
        password = password
    };
    newUser.UserId = users.Count + 1;
    users.Add(newUser);
    User signedUpUser = userService.Signup(newUser);
    if (signedUpUser != null)
    {
        Console.WriteLine("Welcome " + signedUpUser.FirstName + " " + signedUpUser.LastName + "!");
        userContext = signedUpUser;
        Console.WriteLine("please write command for further use");
        userCommand = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Signup failed. Please try again");
        userContext = null;
    }
}

if (userCommand == Command.login.ToString())
{
    Console.WriteLine("Please enter email/username:");
    string username = Console.ReadLine();
    Console.WriteLine("Please enter password:");
    string password = Console.ReadLine();
    int index = users.FindIndex(u =>
    {
        return (u.Email.ToLowerInvariant() == username && u.password == password);
    });
    if (index >= 0)
    {
        userContext = users[index];
        Console.WriteLine("Welcome back" + userContext.FirstName + " " + userContext.LastName + "!");
        Console.WriteLine("please write command for further use");
        userCommand = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Login failed!!!");
        userContext = null;
    }
}

if (userCommand == Command.logout.ToString())
{
    userContext = null;
    Console.WriteLine("User logged out successfully!");
}


while (userContext != null)
{
    if (userCommand == Command.post_feed.ToString())
    {
        commandService = new PostFeedCommandService();
        commandService.CommandCall(userContext);
        Console.WriteLine("please write command for further use");
        userCommand = Console.ReadLine();
    }
    if (userCommand == Command.show_feed.ToString())
    {
        commandService = new ShowNewsFeedCommandService();
        commandService.CommandCall(userContext);
        Console.WriteLine("please write command for further use");
        userCommand = Console.ReadLine();
    }
    if (userCommand == Command.vote_feed.ToString())
    {
        commandService = new VoteNewsFeedCommandService();
        commandService.CommandCall(userContext);
        Console.WriteLine("please write command for further use");
        userCommand = Console.ReadLine();
    }
    if (userCommand == Command.reply_feed.ToString())
    {
        commandService = new CommentOnFeedCommandService();
        commandService.CommandCall(userContext);
        Console.WriteLine("please write command for further use");
        userCommand = Console.ReadLine();
    }
    if (userCommand == Command.vote_reply.ToString())
    {
        commandService = new VoteCommentCommandService();
        commandService.CommandCall(userContext);
        Console.WriteLine("please write command for further use");
        userCommand = Console.ReadLine();
    }
    if (userCommand == Command.reply_comment.ToString())
    {
        commandService = new CommentOnReplyCommandService();
        commandService.CommandCall(userContext);
        Console.WriteLine("please write command for further use");
        userCommand = Console.ReadLine();
    }

}



