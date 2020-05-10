# Customizing Documentation

This part of the manual pertains to the following folders and files:

```
<root>
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
  |        ├── preview.png
  |        └── README.md
  └── .github
      └── workflows
          └── documentation.yml
```

Despite [Unity's recommendation](https://docs.unity3d.com/Manual/cus-layout.html), technically the folders and files in this entire section are optional.  That said, this project aims to take advantage of two things:

1. Automate generating documentation through [Github Actions](https://help.github.com/en/actions/getting-started-with-github-actions/about-github-actions), [DocFX](https://dotnet.github.io/docfx/), and [C# comments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/recommended-tags-for-documentation-comments), and
2. Hide the documentation from Unity Project window's view, by using a trailing `~` in the folder name.

This section covers how to update these files to generate the documentations to your own liking.  Note that the source for most of this information comes from the open-source [DocFX for Unity](https://github.com/NormandErwan/DocFxForUnity) project.

## Github Action Support

FIXME: describe files in .github folder

### `.github/workflows/documentation.yml`

FIXME: describe what needs to change

```
- name: Build
  run: |
    cp CHANGELOG.md Documentation~/manual/changelog.md
    docfx Documentation~/docfx.json
```

### Creating Secret Access Key

FIXME: describe what needs to change

See: https://github.com/JamesIves/github-pages-deploy-action

## DocFX Support

FIXME: describe nearly all the files here

DocFX allows generating documentation from Markdown files and comments in C# scripts.  This project is setup to create a documentation site visually similar to Unity's own packages, with the Markdown files grouped under the top navigation bar's "Manual" button, and documentation from C# scripts grouped under "Scripting API."  To customize the generated site, the files and folders that should be edited is listed below.

### `Documentation~/docfx.json`

FIXME: describe what needs to change
```
"globalMetadata": {
    "_appTitle": "Template Unity Package documentation",
    "_appFooter": "Copyright © 2020 Omiya Games",
    "_enableSearch": true
},
```
FIXME: blah!
```
"sitemap":
{
    "baseUrl": "https://omiyagames.github.io/template-unity-package",
    ...
},
```

### `Documentation~/filterConfig.yml`

FIXME: describe what needs to change
```
- include:
    # Taro Omiya: Updated namespace for this template
    # Including the OmiyaGames.Template namespace
    uidRegex: ^OmiyaGames\.Template$
    type: Namespace
- include:
    # Taro Omiya: Updated namespace for this template
    # Including the OmiyaGames.Template.Editor namespace
    uidRegex: ^OmiyaGames\.Template\.Editor$
    type: Namespace
- include:
    uidRegex: ^Global
    type: Namespace
```

### Files in `Documentation~/manual/`

FIXME: describe what needs to change

#### `Documentation~/manual/toc.yml`

FIXME: describe what needs to change
```
- name: Customizing Package
  items:
  - name: Package Files
    href: customizePackage.md
  - name: Source Code and Assets
    href: customizeSource.md
  - name: Importable Assets
    href: customizeSamples.md
  - name: Documentation
    href: customizeDocumentation.md
- name: Change Log
  href: changelog.md
```

### Files in `Documentation~/resources/`

FIXME: describe what needs to change

## Doxygen Support

FIXME: describe Doxyfile.

### `Documentation~/Doxyfile`

FIXME: describe what needs to change

```
PROJECT_NAME           = "Omiya Games - Template Unity Package"
```

FIXME: describe what needs to change

```
PROJECT_NUMBER         = com.omiyagames.template
```

FIXME: describe what needs to change

```
PROJECT_BRIEF          = "Just a template, acting as a useful starting point to develop a Unity package."
```

FIXME: describe what needs to change