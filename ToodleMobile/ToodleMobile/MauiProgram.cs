namespace ToodleMobile;

using CommunityToolkit.Maui;

/// <summary>
/// Точка входа в приложение.
/// </summary>
public static class MauiProgram
{
    /// <summary>
    /// Создание экземпляра приложения. Используется в кроссплаформенных проектах.
    /// </summary>
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        return builder.Build();
    }
}