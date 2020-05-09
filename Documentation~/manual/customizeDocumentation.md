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

Despite [Unity's recommendation](https://docs.unity3d.com/Manual/cus-layout.html), technically folders and files in this entire section are optional.  That said, this project aims to take advantage of two things:

1. Automate generating documentation through DocFX and C# comments, and
2. Hide the documentation from Unity Project window's view, by using a trailing `~` in the folder name.

## DocFX Support

FIXME: describe nearly all the files here

## Github Action Support

FIXME: describe files in .github folder

## Doxygen Support

FIXME: describe Doxyfile.
