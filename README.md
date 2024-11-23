# QUno

An Uno-like card game.

## Requirements

* Windows 11 or Windows 10
* [.NET 9 SDK](https://dotnet.microsoft.com/download)
* Your favorite editor (my favorite editor is [Visual Studio Code](https://code.visualstudio.com/))
* [Visual Studio 2022](https://visualstudio.microsoft.com/) (I use the Community edition, v17)

## How To Play

`QUnoForms` is a [Windows Forms](https://github.com/dotnet/winforms) application which isn't pretty, but it works. 
Choose *Game > New* to get started.

`QUnoWindows` is a [Windows Presentation Foundation](https://github.com/dotnet/wpf) application which is a little fancier. 
Follow along in the user interface. You can also save a game in progress to a file, and 
then load that file later and continue, if you like to play games the way you work on 
documents.

## Developer Notes

This repository includes straightforward .NET desktop applications implemented in C# and Visual Basic. 
The original code has been in development since .NET Framework v3, but these projects 
have been updated for modern .NET and implemented as SDK-style projects. Thus you can use the 
standard `dotnet build` and `dotnet run` workflow on the individual projects, 
or you can use Visual Studio to open the full solution. 

* The `Library` folder contains prebuilt Debug and Release binaries of the game engine 
that lives in the [QUnoEngine](https://github.com/rdeetz/QUnoEngine) repository.
* `QUnoForms` contains a Visual Basic Windows Forms application, built RAD-style.
* `QUnoWindows` contains a C# Windows Presentation Foundation application using my interpretation of the 
Model-View-ViewModel pattern, attempting to take advantage of what XAML does best and let C# do the rest.

The applications in this repository are intended to be run on any Windows operating system 
that supports .NET and the Desktop runtime.
