namespace ScoreOfRatings;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }
    public async void YoutubeButtonClicked(object sender, EventArgs e)
    {
        try
        {
        await Launcher.Default.OpenAsync("https://www.youtube.com/@TUZMAN9311");
        }
        catch(Exception ex)
        {
            await DisplayAlertAsync("Упс!", "Не удалось открыть ссылку. Похоже, у вас в системе отключен или отсутствует браузер.", "ОК");
        }
    }
    public async void TwitchButtonClicked(object sender, EventArgs e)
    {
        try
        {
            await Launcher.Default.OpenAsync("https://www.twitch.tv/tuzman9311");
        }
        catch(Exception ex)
        {
            await DisplayAlertAsync("Упс!", "Не удалось открыть ссылку. Похоже, у вас в системе отключен или отсутствует браузер.", "ОК");
        }
    }
    public async void KickButtonClicked(object sender, EventArgs e)
    {
        try
        {
            await Launcher.Default.OpenAsync("https://kick.com/tuzman9311");
        }
        catch(Exception ex)
        {
            await DisplayAlertAsync("Упс!", "Не удалось открыть ссылку. Похоже, у вас в системе отключен или отсутствует браузер.", "ОК");
        }
    }
    public async void GitHubButtonClicked(object sender, EventArgs e)
    {
        try
        {
            await Launcher.Default.OpenAsync("https://github.com/TUZMAN9311");
        }
        catch(Exception ex)
        {
            await DisplayAlertAsync("Упс!", "Не удалось открыть ссылку. Похоже, у вас в системе отключен или отсутствует браузер.", "ОК");
        }
    }
}