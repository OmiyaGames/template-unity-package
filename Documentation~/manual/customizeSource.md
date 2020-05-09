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

Per [Unity's documentation](https://docs.unity3d.com/Manual/CustomPackages.html), technically, the only required files in this section is `package.json` and at least one [`*.asmdef` file](https://docs.unity3d.com/Manual/cus-asmdef.html).  Furthermore, all folders can be customized to the developer's liking.  Nonetheless, this template follows the standard recommended by [Unity](https://docs.unity3d.com/Manual/cus-layout.html).

For the sake of brevity, this section will not cover what an [Assembly Definition (*.asmdef) file](https://docs.unity3d.com/Manual/cus-asmdef.html) is, and what purpose it holds.  It is highly recommended to review [Unity's documentation](https://docs.unity3d.com/Manual/cus-asmdef.html) on this file.  Finally, this section will assume the developer chose not to rename the folders, although they *will* need to rename some files.

### Package Manifest - [`package.json`](https://docs.unity3d.com/Manual/upm-manifestPkg.html)

This file is required: it should not be deleted, moved, or renamed.  That said, it *must* be edited.

The Package Manifest file is a text file in JSON format storing details about the package that the Package Manager can use to display and categorize the project.  Note that this file *can* be edited inside the Unity Inspector like any other asset files, as opposed to editing it in the text editor; Unity even provides a nice UI for it.

This section will only focus on one field: defining this package's dependencies.  For more information about this file, check out Unity's [own documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html)!

#### `dependencies`
```
  "dependencies": {
    "com.unity.ext.nunit": "1.0.0"
  },
```
This field is optional, and if this package does not contain any code or plugins, can be safely removed.  If it *does*, this field should be updated to the code's requirements.

As the name implies, `dependencies` is a list of packages this project relies on.  The list of object parameters should be listed in `"<package-unique-identifier>": "<supported-version-of-package>"`.  By default, this template lists the first version of Unity's unit testing package as a dependency.  If, for example, a developer wants to utilize the latest input system into their package, they'll need to list the identifier and version of the package like so (don't forget to add a comma between each package definition):
```
  "dependencies": {
    "com.unity.ext.nunit": "1.0.0",
    "com.unity.inputsystem": "1.0.0"
  },
```
As of this writing, only a specific version number can be defined for each package.  No version range is supported yet.

To learn more, check out [Unity's documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html#dependencies)!


## `Runtime` folder

This folder is intended for scripts that can be utilized when a Unity game runs.  This can include C# scripts, especially `MonoBehaviors`, `ScriptableObjects`, and even just regular classes and structs, as well as plugins and non-editable media files (useful for defining defaults).

If this package does *not* need any such files, e.g. it's purely a Unity Editor tool, this folder, its contents, and its corresponding `Tests/Runtime` folder may be deleted.

#### Assembly Definition - [`Runtime/OmiyaGames.Template.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

If the entire `Runtime` folder and content isn't deleted, this file *must* be renamed and edited.

FIXME: Describe file roles, what needs renaming, content edit, etc!

#### Sample Code - `Runtime/RuntimeExample.cs`

A simple `MonoBehavior` script.  Since it's obviously just a sample file, it's recommended to delete this code.



## `Editor` folder

FIXME: Describe file roles, what needs renaming, content edit, etc!

#### Assembly Definition - [`Editor/OmiyaGames.Template.Editor.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

If the entire `Editor` folder and content isn't deleted, this file *must* be renamed and edited.

FIXME: Describe file roles, what needs renaming, content edit, etc!

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

