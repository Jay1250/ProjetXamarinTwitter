using ProjetXamarinTwitter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetXamarinTwitter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetPage : ContentPage
    {
        private readonly ITwitterService twitterService = new TwitterService();

        public TweetPage()
        {
            InitializeComponent();
            TweetsList.ItemsSource = twitterService.GetTweets();
        }
    
    }
}