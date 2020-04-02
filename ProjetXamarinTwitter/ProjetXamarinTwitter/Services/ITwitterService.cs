using System;
using System.Collections.Generic;
using System.Text;
using ProjetXamarinTwitter.Models;

namespace ProjetXamarinTwitter.Services
{
    interface ITwitterService
    {
        bool Authenticate(string login, string password);

        List<Tweet> GetTweets();
    }
}
