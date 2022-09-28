using PhlegmaticOne.WPF.Core.ViewModels;
using System.Collections.ObjectModel;

namespace PhlegmaticOne.WPF.Core.Sample.Models;

public class AlbumModel : EntityBaseViewModel
{
    public string Title { get; set; } = null!;
    public string ArtistName { get; set; } = null!;
    public ObservableCollection<TrackModel> Tracks { get; set; } = null!;
}