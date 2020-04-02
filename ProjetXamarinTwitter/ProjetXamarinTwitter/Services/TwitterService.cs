using System;
using System.Collections.Generic;
using System.Text;
using ProjetXamarinTwitter.Models;

namespace ProjetXamarinTwitter.Services
{
    class TwitterService : ITwitterService
    {
        private User currentUser = new User { Login = "login", Name = "Jeremy", Password = "password" };


        public bool Authenticate(string login, string password)
        {

            return login == currentUser.Login && password == currentUser.Password; 
        }

        public List<Tweet> GetTweets()
        {
            return new List<Tweet>
            {
                new Tweet {Author = currentUser, PublicationDate = "02/04/2020", Id = "1", Text = "mfzjlsgjsmsg msgjm smejgem mjtmgee kekyme kerkgmrkg me rhrh" },
                new Tweet {Author = currentUser, PublicationDate = "02/04/2020", Id = "2", Text = "mfzjlsgjsmsg msgjm smejgem mjtmgee kekyme kerkgmrkg me rhrh"},
                new Tweet {Author = currentUser, PublicationDate = "02/04/2020", Id = "2", Text = "mfzjlsgjsmsg msgjm smejgem mjtmgee kekyme kerkgmrkg me rhrh"},
                new Tweet {Author = currentUser, PublicationDate = "02/04/2020", Id = "2", Text = "mfzjlsgjsmsg msgjm smejgem mjtmgee kekyme kerkgmrkg me rhrh"}
            };
        }
    }
}
