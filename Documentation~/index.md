# [Omiya Games](https://www.omiyagames.com/) - Template Unity Package

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I3I51KS8F)

![Unity Package Manager](https://omiyagames.github.io/template-unity-package/resources/preview.png)

**Template Unity Package** is a Github template [Omiya Games](https://www.omiyagames.com/) uses to start a new Unity package.  Developers intending to utilize this project as a starting point to develop their own package should [visit the Github page](https://github.com/OmiyaGames/template-unity-package) and:

- If they plan on creating a new online repository on Github directly, click on the green "Use this template" button to get started, or
- Click the "Releases" link, and download the latest archive as zip or gzip file.

The project follows [Unity's recommend file and folder format](https://docs.unity3d.com/Manual/cus-layout.html), albeit with a few changes:

```
<root>
  ├── package.json
  ├── README.md
  ├── CHANGELOG.md
  ├── LICENSE.md
  ├── THIRD PARTY NOTICES.md
  ├── .gitignore
  ├── Editor
  │   ├── OmiyaGames.Template.Editor.asmdef
  │   └── EditorExample.cs
  ├── Runtime
  │   ├── OmiyaGames.Template.asmdef
  │   └── RuntimeExample.cs
  ├── Tests
  │   ├── Editor
  │   │   ├── OmiyaGames.Template.Editor.Tests.asmdef
  │   │   └── EditorExampleTest.cs
  │   └── Runtime
  │        ├── OmiyaGames.Template.Tests.asmdef
  │        └── RuntimeExampleTest.cs
  ├── Samples~
  │   └── Example1
  │       └── Example.txt
  ├── Documentation~
  |    ├── index.md
  |    ├── Doxyfile
  |    ├── docfx.json
  |    ├── toc.yml
  |    ├── filterConfig.yml
  |    ├── manual
  |    |   ├── toc.yml
  |    |   ├── customizeDocumentation.md
  |    |   ├── customizePackage.md
  |    |   ├── customizeSamples.md
  |    |   └── README.md
  |    └── resources
  |        └── README.md
  └── .github
      └── workflows
          └── documentation.yml
```

As many of these files are intended to be edited and/or renamed, this manual has been split up into three parts.  The links below briefly covers how to update this package's files for your own package development.

- [Customizing Package Files](https://omiyagames.github.io/template-unity-package/manual/customizePackage.html)
- [Customizing Importable Assets](https://omiyagames.github.io/template-unity-package/manual/customizeSamples.html)
- [Customizing Documentation](https://omiyagames.github.io/template-unity-package/manual/customizeDocumentation.html)

## Other Resources

- [*How to Split Up an Existing Unity Git Project into Smaller Unity Packages*](https://www.taroomiya.com/2020/04/29/how-to-split-up-an-existing-unity-git-project-into-smaller-unity-packages/): A more fleshed-out tutorial with graphics, by [Taro Omiya's](https://github.com/japtar10101)
- This project's [Github Repository](https://github.com/OmiyaGames/template-unity-package)
- This project's [Change Log](https://github.com/OmiyaGames/template-unity-package/blob/master/CHANGELOG.md)

## LICENSE

Overall package is licensed under [MIT](https://github.com/OmiyaGames/template-unity-package/blob/master/LICENSE.md), unless otherwise noted in the [3rd party licenses](https://github.com/OmiyaGames/template-unity-package/blob/master/THIRD%20PARTY%20NOTICES.md) file and/or source code.

Copyright (c) 2019-2020 Omiya Games
