[![NuGet](https://img.shields.io/nuget/v/Microsoft.Orleans.Templates.svg?style=flat)](http://www.nuget.org/profiles/Orleans)
[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/dotnet/orleans?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

# Overview

This project contains the templates for getting started with [Orleans](https://github.com/dotnet/orleans).

The templates are leveraging the [dotnet templating engine](https://github.com/dotnet/templating).

# Installation

The templates can be consumed in two ways.

## Visual Studio 2017

If you like to use the project templates from Visual Studio 2017, the minimum supported version is 15.3, since this version added support to the unfolding of templates based on the new dotnet templating engine.

VS Gallery link: [Microsoft Orleans Templates](https://visualstudiogallery.msdn.microsoft.com/)

Template updates for Visual Studio 2017 can be done by updating the installed VSIX.

## .NET Core command-line (CLI)

.NET Core command-line (CLI) template installation can be done by invoking ```dotnet.exe``` from the shell. The minimum version required is 2.0.

```
dotnet new --install Microsoft.Orleans.Templates::*
```

The template installation can be checked with the following command line:

```
dotnet new
```

The output should contain the Orleans Templates amongst the other installed templates:

```
Templates                                         Short Name           Language          Tags
---------------------------------------------------------------------------------------------------------------------
Orleans Grain Class Collection                    grains               [C#], F#, VB      Orleans
Orleans Grain Interface Collection                graininterfaces      [C#], VB          Orleans
Orleans Client Application                        clusterclient        [C#]              Orleans
Orleans Silo Host                                 silohost             [C#]              Orleans
Orleans Grain Interface                           graininterface       [C#]              Orleans
Orleans Solution                                  orleans              [C#]              Orleans
```

# Creating your first Orleans application

Execute the following command from any CLI shell.

```bash
dotnet new orleans -n Contoso
```

You should now have a Contoso directory with a solution setup and ready to go. The directory structure will look like:

- Contoso.sln
- src
    - ClusterClient
    - Grains
    - GrainInterfaces
    - SiloHost

You can even open it with VS Code, build, and run it out of the box. Of course, you don't have to use VS Code, you could use Visual Studio, or VIM and the dotnet CLI.

>If you are using VS Code, be sure and select the "Silo Host / Cluster Client" debug configuration to launch the Silo Host and the Cluster Client at the *same time*.

# Creating your second Orleans application

Of course, sometimes the first steps require a steadier footing. If you want to manage the solution from the ground up, you're welcome to add each component individually.

The following commands should be executed from any CLI shell.

Create a Blank Solution:
```
dotnet new sln -n Contoso
```

Create the Grain interfaces project and add it to the Solution:
```
dotnet new graininterfaces -n Contoso.GrainInterfaces
dotnet sln add Contoso.GrainInterfaces\Contoso.GrainInterfaces.csproj
```
Create the Grain implementation project and add it to the Solution:
```
dotnet new grains -n Contoso.Grains
dotnet sln add Contoso.Grains\Contoso.Grains.csproj
```

Add a project reference for the Grain interface project to the Grain implementation project:
```
dotnet add Contoso.Grains reference Contoso.GrainInterfaces\Contoso.GrainInterfaces.csproj
```

Add ```using Contoso.GrainInterfaces;``` to the ```Contoso.Grains\Grain1.cs``` file.

Create the Silo host project and add it to the Solution:
```
dotnet new silohost -n Contoso.Silo
dotnet sln add Contoso.Silo\Contoso.Silo.csproj
```

Add a project reference for the Grain implementation project to the Silo host project:
```
dotnet add Contoso.Silo reference Contoso.Grains\Contoso.Grains.csproj
```

Add ```using Contoso.Grains;``` to the ```Contoso.SiloHost\Program.cs``` file.

After the ```UseConfiguration(config)``` line in ```Program.cs``` add, to register the grain classes with the Silo:
```.AddApplicationPartsFromReferences(typeof(Grain1).Assembly)```

Create a cluster client application and add it to the Solution:

```
dotnet new orleansclient -n Contoso.ClusterClient
dotnet sln add Contoso.ClusterClient\Contoso.ClusterClient.csproj
```

Add a project reference for the Grain interface project to the Cluster Client application project:
```
dotnet add Contoso.ClusterClient reference Contoso.GrainInterfaces\Contoso.GrainInterfaces.csproj
```

Add ```using Contoso.GrainInterfaces;``` to the ```Contoso.ClusterClient\Program.cs``` file.

After the ```UseConfiguration(config)``` line in ```Program.cs``` add, to register the grain interfaces with the client:
```.AddApplicationPartsFromReferences(typeof(IGrain1).Assembly)```

Build the solution:
```
dotnet build
```

## Congratulations, you created your first - yet empty - Orleans application.

Now you can add methods to the Grain interfaces project and Grain implementation project, then call it from the client application.

# Building the template solution

The template project is an old style ```csproj```, so it only can built with ```MSBuild.exe```. Since the Package Restore is not automatic in this case that's must be done first.

Since NuGet workload was not part of VS Build payload before 15.4, on build servers 15.4 needed.

On a desktop Visual Studio 2017 installation a ```Developer Command Prompt``` need to be opened, then the following 2 commands are building the solution:
```
msbuild /t:restore
msbuild
```

# Contribution

If you like to contribute to the development of Orleans Templates, here are some useful links about ```dotnet``` templates:

- [dotnet CLI official documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore2x)
- [How to create templates](https://aka.ms/dotnetnew-create-templates)
- [Template Engine repository](https://github.com/dotnet/templating)
- [Template Engine samples repository](https://github.com/dotnet/dotnet-template-samples)
- [Template Engine Wiki](https://github.com/dotnet/templating/wiki)
- [Sidewaffle Creator](https://marketplace.visualstudio.com/items?itemName=Sayed-Ibrahim-Hashimi.SidewaffleCreator2017)

# Blog
[Orleans Blog](https://blogs.msdn.microsoft.com/orleans) is a place to share our thoughts, plans, learnings, tips and tricks, and ideas, crazy and otherwise, which don’t easily fit the documentation format. We would also like to see here posts from the community members, sharing their experiences, ideas, and wisdom.
So, welcome to Orleans Blog, both as a reader and as a blogger!

# Community

- Ask questions by [opening an issue on GitHub](https://github.com/dotnet/orleans-templating/issues) or on [Stack Overflow](https://stackoverflow.com/questions/ask?tags=orleans-templating)
- [Chat on Gitter](https://gitter.im/dotnet/orleans)
- Follow the [@MSFTOrleans](https://twitter.com/MSFTOrleans) Twitter account for Orleans announcements.

# License

This project is licensed under the [MIT license](https://github.com/dotnet/orleans-templating/blob/master/LICENSE).

# Quick Links

- [MSR-ProjectOrleans](http://research.microsoft.com/projects/orleans)
- Orleans Tech Report - [Distributed Virtual Actors for Programmability and Scalability]-(http://research.microsoft.com/apps/pubs/default.aspx?id=210931)
- [Orleans-GitHub](https://github.com/dotnet/orleans)
- [Orleans Documentation](http://dotnet.github.io/orleans)

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
