using PhlegmaticOne.WPF.Core.Sample.ViewModels;
using System.Windows;

namespace PhlegmaticOne.WPF.Core.Sample;

public partial class MainWindow : Window
{
    public MainWindow(AlbumViewModel albumViewModel)
    {
        InitializeComponent();
        DataContext = albumViewModel;
    }
}
