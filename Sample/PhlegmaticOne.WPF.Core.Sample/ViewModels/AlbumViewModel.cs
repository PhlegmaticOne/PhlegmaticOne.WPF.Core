using PhlegmaticOne.WPF.Core.Commands;
using PhlegmaticOne.WPF.Core.Sample.Models;
using PhlegmaticOne.WPF.Core.Sample.Services;
using PhlegmaticOne.WPF.Core.ViewModels;

namespace PhlegmaticOne.WPF.Core.Sample.ViewModels;

public class AlbumViewModel : ApplicationBaseViewModel
{
	public AlbumModel Album { get; set; }
	public AlbumViewModel(IAlbumRepository albumRepository)
	{
		Album = albumRepository.GetAlbum();
		RemoveTrackCommand = RelayCommandFactory.CreateRequiredParameterCommand<TrackModel>(RemoveTrack, _ => true);
	}

	public IRelayCommand RemoveTrackCommand { get; }
	private void RemoveTrack(TrackModel track)
	{
		Album.Tracks.Remove(track);
	}
}
