namespace GasMatic.Client.Core.Services.Alerts;

public interface IAlertService
{
    Task ShowAlertAsync(string title, string message, string cancel);

    Task<bool> ShowConfirmationPromptAsync(
        string title,
        string message,
        string accept,
        string cancel);

    Task ShowSnackbarAsync(string text);
}