# [Omiya Games](https://www.omiyagames.com/) - Template Unity Package

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I3I51KS8F)

![Unity Package Manager](https://omiyagames.github.io/template-unity-package/resources/preview.png)

**Template Unity Package** is a Github template [Omiya Games](https://www.omiyagames.com/) uses to start a new Unity package.  Developers intending to utilize this project as a starting point to develop their own package should [visit the Github page](https://github.com/OmiyaGames/template-unity-package) and:

- If they plan on creating a new online repository on Github directly, click on the green "Use this template" button to get started, or
- Click the "Releases" link, and download the latest archive as zip or gzip file.

## Structure

The project follows [Unity's recommend file and folder format](https://docs.unity3d.com/Manual/cus-layout.html), albeit with a few changes:

```
<root>
  ├── package.json
  ├── README.md
  ├── CHANGELOG.md
  ├── LICENSE.md
  ├── THIRD PARTY NOTICES.md
  ├── .gitignore
  ├── Runtime
  │   ├── OmiyaGames.Template.asmdef
  │   └── RuntimeExample.cs
  ├── Editor
  │   ├── OmiyaGames.Template.Editor.asmdef
  │   └── EditorExample.cs
  └── Tests
  │   ├── Runtime
  │   │   ├── OmiyaGames.Template.Tests.asmdef
  │   │   └── RuntimeExampleTest.cs
  │   └── Editor
  │       ├── OmiyaGames.Template.Editor.Tests.asmdef
  │       └── EditorExampleTest.cs
  ├── Samples~
  │   └── Example1
  │       └── Example.txt
  ├── Documentation~
  |   ├── index.md
  |   ├── Doxyfile
  |   ├── docfx.json
  |   ├── toc.yml
  |   ├── filterConfig.yml
  |   ├── manual
  |   |   ├── toc.yml
  |   |   ├── customizeDocumentation.md
  |   |   ├── customizePackage.md
  |   |   ├── customizeSamples.md
  |   |   └── README.md
  |   └── resources
  |       ├── preview.png
  |       └── README.md
  └── .github
      ├── FUNDING.yml
      ├── ISSUE_TEMPLATE
      |   ├── bug_report.md
      |   ├── feature_request.md
      |   ├── documentation-template.md
      |   └── research_template.md
      └── workflows
          ├── documentation.yml
          └── mirror.yml
```

## Common Text Formats

Note that this sprawling list of files contains a large number of common, human-readable (i.e. non-code, data-storing) text formats.  If some of these file extensions are unfamiliar, the following resources describes how to edit and format the most common text files used in this project:

- [JSON (`*.json, *.asmdef`)](https://www.json.org/json-en.html)
    - Although the [Wikipedia page](https://en.wikipedia.org/wiki/JSON#Data_types_and_syntax) might be easier understand.
- [YAML (`*.yml`)](https://yaml.org/spec/1.2/spec.html#Preview)
    - Again, the [Wikipedia page](https://en.wikipedia.org/wiki/YAML#Syntax).
- [Markdown (`*.md`)](https://www.markdownguide.org/getting-started/)
    - They also provide [a cheatsheet](https://www.markdownguide.org/cheat-sheet)!
- [Bonus: `.gitignore`](https://git-scm.com/docs/gitignore#_pattern_format)

## About the Manual

As many of these files are intended to be edited and/or renamed, this manual has been split up into three parts.  The links below briefly covers how to update this package's files for your own package development.

- [Customizing Package Files](https://omiyagames.github.io/template-unity-package/manual/customizePackage.html)
- [Adding Source Code and Assets](https://omiyagames.github.io/template-unity-package/manual/customizeSource.html)
- [Adding Importable Assets](https://omiyagames.github.io/template-unity-package/manual/customizeSamples.html)
- [Customizing Documentation](https://omiyagames.github.io/template-unity-package/manual/customizeDocumentation.html)

As an aside, [the author](https://github.com/japtar10101) of this manual provided a more thorough guide with graphics on their own blog: [*How to Split Up an Existing Unity Git Project into Smaller Unity Packages*](https://www.taroomiya.com/2020/04/29/how-to-split-up-an-existing-unity-git-project-into-smaller-unity-packages/).  It's worth reviewing if the manual seems a little sparse.  Finally, changes in the project is documented under the [change log page](https://omiyagames.github.io/template-unity-package/manual/changelog.html).

## LICENSE

Overall package is licensed under [MIT](https://github.com/OmiyaGames/template-unity-package/blob/master/LICENSE.md), unless otherwise noted in the [3rd party licenses](https://github.com/OmiyaGames/template-unity-package/blob/master/THIRD%20PARTY%20NOTICES.md) file and/or source code.
