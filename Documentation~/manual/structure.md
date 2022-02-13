# Package Structure

The project follows [Unity's recommend file and folder format](https://docs.unity3d.com/Manual/cus-layout.html), albeit with a few changes:

```text
<root>
  ├── package.json
  ├── README.md
  ├── CHANGELOG.md
  ├── LICENSE.md
  ├── THIRD PARTY NOTICES.md
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
  |   ├── Doxyfile
  |   ├── docfx.json
  |   ├── toc.yml
  |   ├── filterConfig.yml
  |   ├── manual
  |   |   ├── toc.yml
  |   |   ├── structure.md
  |   |   ├── customizeDocumentation.md
  |   |   ├── customizePackage.md
  |   |   ├── customizeSamples.md
  |   |   └── README.md
  |   └── resources
  |       ├── preview.png
  |       ├── samples.png
  |       ├── addingSecrets.png
  |       ├── personalAccessToken.png
  |       └── README.md
  ├── .gitignore
  └── .github
      ├── FUNDING.yml
      ├── ISSUE_TEMPLATE
      |   ├── bug_report.md
      |   ├── feature_request.md
      |   ├── documentation-template.md
      |   └── research_template.md
      └── workflows
          └── documentation.yml
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
