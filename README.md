# PhlegmaticOne.WPF.Core
![Logo - Copy](https://user-images.githubusercontent.com/73738250/192877116-bf055039-8220-4ec7-bec0-66c1e269910f.png)
##

### Nuget package
[PhlegmaticOne.WPF.Core](https://www.nuget.org/packages/PhlegmaticOne.WPF.Core/)
##

### Installation
```
PM> NuGet\Install-Package PhlegmaticOne.WPF.Core -Version 1.1.1
```
## Usage
```BaseViewModel``` from [PhlegmaticOne.WPF.Core](https://www.nuget.org/packages/PhlegmaticOne.WPF.Core/) package implements ```INotifyPropertyChanged```, but in ViewModels that you will create you need to invoke ```OnPropertyChanged``` method in all properties in every your ViewModel explicitly.

To avoid this install the package [PropertyChanged.Fody](https://www.nuget.org/packages/PropertyChanged.Fody/)

And then see sample :)
