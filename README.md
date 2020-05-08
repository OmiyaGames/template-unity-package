# [Omiya Games](https://www.omiyagames.com/) - Template Unity Package

[![Template Unity Package documentation](https://github.com/OmiyaGames/template-unity-package/workflows/Template%20Unity%20Package%20documentation/badge.svg)](https://omiyagames.github.io/template-unity-package/) [![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I3I51KS8F)

**Template Unity Package** is a Github template [Omiya Games](https://www.omiyagames.com/) uses to start a new [Unity](https://unity.com/) package.  To use this template for your own purposes, we recommend consulting the following:

- [Package Documentation](https://omiyagames.github.io/template-unity-package/)
- [*How to Split Up an Existing Unity Git Project into Smaller Unity Packages*](https://www.taroomiya.com/2020/04/29/how-to-split-up-an-existing-unity-git-project-into-smaller-unity-packages/) by [Taro Omiya](https://github.com/japtar10101)

This package uses [DocFX](https://dotnet.github.io/docfx/) and Github Actions to auto-generate its documentation from both the comments in the source code and the Markdown files in the [`Documentation~`](/Documentation~) directory.  Consult the manual on [customizing documentation files](https://omiyagames.github.io/template-unity-package/manual/customizeDocumentation.html) for your own packages.  There is also has a pre-made [Doxygen](https://github.com/doxygen/doxygen) settings file in the same directory to run Doxywizard through.

## Install

There are two common methods for installing this package.

### Through Unity Package Manager

Unity's own Package Manager supports importing packages via the URL to a Git repository.  Just click on the + button on the upper-left-hand corner of the Package Manager, select Git URL, then enter this package's HTTPS Github URL!

While easy and straightforward, this method has a few major downside: it does not support dependency resolution and package upgrading when a new version is released.  To add support for that, the following method is recommended:

### Through [OpenUPM](https://openupm.com/)

Installing via [OpenUPM's command line tool](https://openupm.com/) is recommended because it supports dependency resolution, upgrading, and downgrading this package.  Given this package is just an example, thought, it hadn't been added into OpenUPM yet.  So the rest of these instructions are hypothetical...for now...

To [install OpenUPM](https://openupm.com/docs/getting-started.html#installing-openupm-cli) (if you haven't already) make sure Node.js is installed in your system first, then run:
```
npm install -g openupm-cli
```
To install this package, just run:
```
openupm add com.omiyagames.template
```

## Resources

- [Documentation](https://omiyagames.github.io/template-unity-package/)
- [Change Log](/CHANGELOG.md)

## LICENSE

Overall package is licensed under [MIT](/LICENSE.md), unless otherwise noted in the [3rd party licenses](/THIRD%20PARTY%20NOTICES.md) file and/or source code.

Copyright (c) 2019-2020 Omiya Games
