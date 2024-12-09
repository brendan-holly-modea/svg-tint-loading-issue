using FFImageLoading.Maui;

namespace SvgTintLoadingIssue;

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
