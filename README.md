# PhlegmaticOne.WPF.Core
![Logo - Copy](https://user-images.githubusercontent.com/73738250/192877116-bf055039-8220-4ec7-bec0-66c1e269910f.png)
##

### Nuget package
[PhlegmaticOne.WPF.Core](https://www.nuget.org/packages/PhlegmaticOne.WPF.Core/)
##

### Installation
```
PM> NuGet\Install-Package PhlegmaticOne.WPF.Core -Version 1.1.4
```
## Usage
```BaseViewModel``` from [PhlegmaticOne.WPF.Core](https://www.nuget.org/packages/PhlegmaticOne.WPF.Core/) package implements ```INotifyPropertyChanged```, but in ViewModels that you will create you need to invoke ```OnPropertyChanged``` method in all properties in every your ViewModel explicitly.

To avoid this install the package [PropertyChanged.Fody](https://www.nuget.org/packages/PropertyChanged.Fody/)

## WPF Models
```csharp
public class AlbumModel : EntityBaseViewModel
{...}
```

## WPF ViewModels
```csharp
public class AlbumViewModel : ApplicationBaseViewModel
{...}
```

## WPF Commands Creation
```csharp
public class AlbumViewModel : ApplicationBaseViewModel
{
	...
  public AlbumViewModel(...)
  {
      ...
      RemoveTrackCommand = RelayCommandFactory.CreateRequiredParameterCommand<TrackModel>(RemoveTrack);
  }
  public IRelayCommand RemoveTrackCommand { get; }
  private void RemoveTrack(TrackModel track)
  {
      Album.Tracks.Remove(track);
  }
  ...
}
```

## Also sample on GitHub is available
