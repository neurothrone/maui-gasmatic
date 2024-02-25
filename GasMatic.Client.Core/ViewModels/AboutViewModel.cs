using CommunityToolkit.Mvvm.Input;
using GasMatic.Client.Core.Services;
using GasMatic.Client.Core.Services.Environment;
using GasMatic.Client.Core.Services.Interactions;

namespace GasMatic.Client.Core.ViewModels;

public partial class AboutViewModel(
    IAppInteractionsService appInteractionsService,
    IConfigurationService configurationService)
{
    private const string LinkedinUrl = "https://www.linkedin.com/in/neurothrone/";

    public string AppTitle => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string Author => "Zane Neurothrone";
    public string DotNetTextCredits => "This app is powered by .NET MAUI";
    public string DotNetDetailCredits => "Written in XAML & C#";
    public string AppIconCredit => "App icon by svgrepo.com";

    [RelayCommand]
    private async Task OpenSupportEmailLink()
    {
        await appInteractionsService.ComposeSupportEmailAsync(
            configurationService.GetSupportEmail(),
            "GasMatic Support"
        );
    }

    [RelayCommand]
    private async Task OpenLinkedinWebLink() => await appInteractionsService.OpenBrowserAsync(LinkedinUrl);
}