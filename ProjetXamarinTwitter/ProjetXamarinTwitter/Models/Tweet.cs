using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetXamarinTwitter.Models
{
    public class Tweet
    {
        public string Id { get; set; }
        public string PublicationDate { get; set; }
        public string Text { get; set; }
        public User Author { get; set; }
    }
}