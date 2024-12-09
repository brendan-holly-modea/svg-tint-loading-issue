namespace SvgTintLoadingIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void GoToNextPage(object sender, EventArgs e)
    {
        // It doesn't matter if we route via shell or 
        Navigation.PushAsync(new CopyMainPage());
    }
}