namespace ScoreOfRatings;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }
    public async void YoutubeButtonClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://www.youtube.com/@TUZMAN9311");
    }
    public async void TwitchButtonClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://www.twitch.tv/tuzman9311");
    }
    public async void KickButtonClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://kick.com/tuzman9311");
    }
    public async void GitHubButtonClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/TUZMAN9311");
    }
}