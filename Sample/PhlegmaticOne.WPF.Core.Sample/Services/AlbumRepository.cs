using PhlegmaticOne.WPF.Core.Sample.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace PhlegmaticOne.WPF.Core.Sample.Services;

public class AlbumRepository : IAlbumRepository
{
    public AlbumModel GetAlbum()
    {
        var tracks = Enumerable.Range(0, 10).Select(x => new TrackModel { Title = "Track" + x }).ToList();
        var observableCollection = new ObservableCollection<TrackModel>(tracks);
        return new AlbumModel
        {
            ArtistName = "Artist",
            Id = Guid.Empty,
            Title = "Title",
            Tracks = observableCollection
        };
    }
}
