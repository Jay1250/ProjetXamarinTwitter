using ProjetXamarinTwitter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProjetXamarinTwitter
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private readonly ITwitterService twitterService = new TwitterService();
        
        public async void Connection(object sender, EventArgs e)
        {

            if (this.login.Text == null || string.IsNullOrEmpty(this.login.Text.ToString()))
            {
                this.GenerateError("Veuillez renseigner un identifiant");
                return;
            }
            if (this.login.Text.Length < 3)
            {
                this.GenerateError("L'identifiant doit faire au moins 3 caractères");
                return;
            }
            if (this.password.Text == null || string.IsNullOrEmpty(this.password.Text.ToString()))
            {
                this.GenerateError("Veuillez renseigner un mot de passe");
                return;
            }
            if (this.password.Text.Length < 6)
            {
                this.GenerateError("Le mot de passe doit faire au moins 6 caractères");
                return;
            }
            NetworkAccess networkAccess = Connectivity.NetworkAccess;

            if (networkAccess != NetworkAccess.Internet)
            {
                this.GenerateError("Veuillez vous connecter à internet");
                return;
            }
            if (!this.twitterService.Authenticate(this.login.Text, this.password.Text))
            {
                this.GenerateError("L'identifiant et/ou le mot de passe sont incorrects");
                return;
            }
            await Navigation.PushAsync(new TweetPage());

        }

        private void GenerateError(string message = null)
        {
            if (message != null)
            {
                this.error.Text = message;
                error.IsVisible = true;
            }
        }
    }
}
