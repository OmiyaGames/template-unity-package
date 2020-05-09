# Adding Source Code and Assets

This part of the manual pertains to the following folders and files:

```
<root>
  ├── package.json
  ├── Runtime
  │   ├── OmiyaGames.Template.asmdef
  │   └── RuntimeExample.cs
  ├── Editor
  │   ├── OmiyaGames.Template.Editor.asmdef
  │   └── EditorExample.cs
  └── Tests
      ├── Runtime
      │   ├── OmiyaGames.Template.Tests.asmdef
      │   └── RuntimeExampleTest.cs
      └── Editor
          ├── OmiyaGames.Template.Editor.Tests.asmdef
          └── EditorExampleTest.cs
```

Per [Unity's documentation](https://docs.unity3d.com/Manual/CustomPackages.html), technically, the only required files in this section is `package.json` and at least one [`*.asmdef` file](https://docs.unity3d.com/Manual/cus-asmdef.html).  Furthermore, all folders do *not* have to be named the way they are, or put into hierarchy the way they are.  Nonetheless, this template attempts to follow the standard set by [Unity's documentation](https://docs.unity3d.com/Manual/cus-layout.html) to keep things consistent.

This section will assume the developer will choose not to rename the folders, although they *will* need to rename at least one file under each folder:

### Package Manifest - [`package.json`](https://docs.unity3d.com/Manual/upm-manifestPkg.html)

FIXME: Describe file roles, and what fields are relevant for this section.

This file is required; it should not be deleted, moved, or renamed.



## `Runtime` folder

FIXME: Describe file roles, what needs renaming, content edit, etc!

#### Assembly Definition - [`Runtime/OmiyaGames.Template.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

FIXME: Describe file roles, what needs renaming, content edit, etc!

If the entire `Runtime` folder and content isn't deleted, this file *must* be renamed and edited.

#### Sample Code - `Runtime/RuntimeExample.cs`

A simple `MonoBehavior` script.  Since it's obviously just a sample file, it's recommended to delete this code.



## `Editor` folder

FIXME: Describe file roles, what needs renaming, content edit, etc!

#### Assembly Definition - [`Editor/OmiyaGames.Template.Editor.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

FIXME: Describe file roles, what needs renaming, content edit, etc!

If the entire `Editor` folder and content isn't deleted, this file *must* be renamed and edited.

#### Sample Code - `Editor/EditorExample.cs`

A simple `Editor` script.  Since it's obviously just a sample file, it's recommended to delete this code.



## `Tests`, and its subfolders

FIXME: Describe file roles, what needs renaming, content edit, etc!

#### Editor Test Assembly Definition - [`Tests/Editor/OmiyaGames.Template.Editor.Tests.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

FIXME: Describe file roles, what needs renaming, content edit, etc!

If the entire `Tests/Editor` folder and content isn't deleted, this file *must* be renamed and edited.

#### Editor Sample Unit Test - `Tests/Editor/EditorExampleTest.cs`

A simple NUnit test script.  Since it's obviously just a sample file, it's recommended to delete this code.

#### Runtime Test Assembly Definition - [`Tests/Editor/OmiyaGames.Template.Tests.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

FIXME: Describe file roles, what needs renaming, content edit, etc!

If the entire `Tests/Runtime` folder and content isn't deleted, this file *must* be renamed and edited.

#### Runtime Sample Unit Test - `Tests/Editor/RuntimeExampleTest.cs`

A simple NUnit test script.  Since it's obviously just a sample file, it's recommended to delete this code.

