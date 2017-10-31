[![NuGet](https://img.shields.io/nuget/v/Microsoft.Orleans.Templates.svg?style=flat)](http://www.nuget.org/profiles/Orleans)
[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/dotnet/orleans?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

# Overview

This project contains the Project and Item templates to make it easier to getting started with [Orleans](https://github.com/dotnet/orleans).

The templates are leveraging the new [dotnet templating engine](https://github.com/dotnet/templating).

# Provided templates


# Installation

The templates can be consumed in two ways.

## Visual Studio 2017

If you like to use the project templates from Visual Studio 2017, the minimum supported version is 15.3, since this version added support to the unfolding of templates based on the new dotnet templating engine.

VS Gallery link: [Microsoft Orleans Templates](https://visualstudiogallery.msdn.microsoft.com/)

Template updates for Visual Studio 2017 can be done by updating the installed VSIX.

## .NET Core command-line (CLI)

.NET Core command-line (CLI) template installation can be done by invoking ```dotnet.exe``` from the shell. The minimum version required is 2.0.

```
dotnet new --install Microsoft.Orleans.Templates:*
```

The template installation can be checked with the following command line:

```
dotnet new
```

The output should contain the Orleans Templates amongst the other installed templates:

```
Templates                                         Short Name           Language                   Tags
---------------------------------------------------------------------------------------------------------------------
Orleans Grain Class Collection                    grains               [C#], F#, VB               Orleans
Orleans Grain Interface Collection                graininterfaces      [C#], VB                   Orleans
Orleans Grain Interface                           graininterface       [C#]                       Orleans
```

The [official documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore2x) of the CLI provides detailed usage of the available command line options.

# Contribution

If you like to contribute to the development of Orleans Templates, here are some useful links about ```dotnet``` templates:

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
