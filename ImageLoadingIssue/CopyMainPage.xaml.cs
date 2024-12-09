using FFImageLoading.Maui;

namespace ImageLoadingIssue;

public partial class CopyMainPage : ContentPage
{
    private ImageSource _testImageSource;
    public ImageSource TestImageSource
    {
        get => _testImageSource;
        set
        {
            if (_testImageSource != value)
            {
                _testImageSource = value;
                OnPropertyChanged(nameof(TestImageSource));
            }
        }
    }
    public CopyMainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}
