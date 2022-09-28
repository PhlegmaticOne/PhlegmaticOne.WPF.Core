using PhlegmaticOne.WPF.Core.Sample.Services;
using PhlegmaticOne.WPF.Core.Sample.ViewModels;
using System.Windows;

namespace PhlegmaticOne.WPF.Core.Sample;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var albumRepository = new AlbumRepository();
        var albumViewModel = new AlbumViewModel(albumRepository);
        var mainWindow = new MainWindow(albumViewModel);
        mainWindow.Show();
    }
}
