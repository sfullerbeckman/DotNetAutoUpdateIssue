using System.Configuration;
using System.Data;
using System.Windows;

namespace HostApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        this.DispatcherUnhandledException += (s, e) =>
        {
            MessageBox.Show(
                $"Unhandled exception:\n{e.Exception.GetType().Name}\n{e.Exception.Message}",
                ".NET Update Repro");
            e.Handled = true;
        };
    }
}

