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

Note that if the project *only* contains importable assets, the folder `Runtime`, `Editor`, `Tests`, and all their subfolders and content can be deleted safely (yes, even the `*.asmdef` files, as far as this writer is aware).  Do not forget to update the `package.json` file accordingly, as detailed below.

For the sake of brevity, this section will not cover what an [Assembly Definition (*.asmdef) file](https://docs.unity3d.com/Manual/cus-asmdef.html) is, and what purpose it holds.  It is highly recommended to review [Unity's documentation](https://docs.unity3d.com/Manual/cus-asmdef.html) on this file.  Finally, this section will assume the developer chose not to rename the folders, although they *will* need to rename some files.

### Package Manifest - [`package.json`](https://docs.unity3d.com/Manual/upm-manifestPkg.html)

This file is required: it should not be deleted, moved, or renamed.  That said, it *must* be edited.

The Package Manifest file is a text file in JSON format storing details about the package that the Package Manager can use to display and categorize the project.  Note that this file *can* be edited inside the Unity Inspector like any other asset files, as opposed to editing it in the text editor; Unity even provides a nice UI for it.

This section will only focus on one field: defining this package's dependencies.  For more information about this file, check out Unity's [own documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html)!

#### `dependencies`
```json
"dependencies": {
  "com.unity.ext.nunit": "1.0.0"
},
```
This field is optional, and if this package does not contain any code or plugins, can be safely removed.  If it *does*, this field should be updated to the code's requirements.

As the name implies, `dependencies` is a list of packages this project relies on.  The list of object parameters should be listed in `"<package-unique-identifier>": "<supported-version-of-package>"`.  By default, this template lists the first version of Unity's unit testing package as a dependency.  If, for example, a developer wants to utilize the latest input system into their package, they'll need to list the identifier and version of the package like so (don't forget to add a comma between each package definition):
```json
"dependencies": {
  "com.unity.ext.nunit": "1.0.0",
  "com.unity.inputsystem": "1.0.0"
},
```
As of this writing, only a specific version number can be defined for each package.  No version range is supported yet.

To learn more, check out [Unity's documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html#dependencies)!


## `Runtime` folder

This folder is intended for scripts that can be utilized when a Unity game runs.  This can include C# scripts, especially `MonoBehaviors`, `ScriptableObjects`, Attributes, and even just regular classes and structs, as well as plugins and non-editable media files (useful for defining defaults).

If this package does *not* need any such files, e.g. it's purely a Unity Editor tool, this folder, its contents, and its corresponding `Tests/Runtime` folder may be dafely deleted.

#### Assembly Definition - [`Runtime/OmiyaGames.Template.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

If the entire `Runtime` folder and content isn't deleted, this file *must* be renamed and edited.

This is the file that will group the source code in the `Runtime` folder into a single C# project, separating it from the rest of the folders in the package, as well as the Unity project when this package gets imported.  The file name, which needs to be unique, should be changed to match either the package's unique identifier with capitalization, or the namespace the scripts are scoped in (preferably both).  After renaming the file, the following fields in it should be updated:

- `name`: must be unique from other Assembly Definition files.  Recommended to be updated to match the namespace the scripts are scoped in.
- `references`: list of C# projects the source code depends on.  The name of each project should be the same as the `name` field in the Assembly Definition file in said dependencies.
- `includePlatforms`: a list of platforms this project supports.  Keep the list empty if all platforms should be supported.
- `excludePlatforms`: a list of platforms this project *does not* supports.  Keep the list empty if all platforms should be supported.

Editing this file can be done in the Unity Inspector window, when the file is selected in the Project window, or a typical text editor.  Don't forget to check out [Unity's documentation](https://docs.unity3d.com/Manual/cus-asmdef.html) for more information on the rest of the fields in the file!

#### Sample Code - `Runtime/RuntimeExample.cs`

A simple `MonoBehavior` script.  Since it's obviously just a sample file, it's recommended to delete this code.



## `Editor` folder

This folder is intended for scripts that customizes the Unity editor in some way, but isn't used in the game itself.  This basically means any editor C# scripts, such as `Editor`, `PropertyDrawers`, and `SettingsProvider`.  If the code has the line, `using UnityEditor;` or some variant near the top of the file, it's very much an editor script and belongs here.

If this package does *not* need any such files, e.g. it's purely a Runtime tool, plugin, or a bunch of default assets, this folder and its contents may be safely deleted.

#### Assembly Definition - [`Editor/OmiyaGames.Template.Editor.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

If the entire `Editor` folder and content isn't deleted, this file *must* be renamed and edited.

This is the file that will group the source code in the `Editor` folder into a single C# project, separating it from the rest of the folders in the package, as well as the Unity project when this package gets imported.  The file name, which needs to be unique, should be changed to match either the package's unique identifier with capitalization, or the namespace the scripts are scoped in (preferably both).  If the `Runtime` folder still exists, don't forget to add `.Editor` in the file name as well to differentiate the two.  After renaming the file, the following fields in it should be updated:

- `name`: must be unique from other Assembly Definition files.  Recommended to be updated to match the namespace the scripts are scoped in.
- `references`: list of C# projects the source code depends on.  The name of each project should be the same as the `name` field in the Assembly Definition file in said dependencies.  If the `Runtime` folder exists, don't forget to add the `name` of the corresponding Assembly Definition files in this list as well.

Editing this file can be done in the Unity Inspector window, when the file is selected in the Project window, or a typical text editor.  Note that the fields, `includePlatforms` and `excludePlatforms` should already be set properly.  Don't forget to check out [Unity's documentation](https://docs.unity3d.com/Manual/cus-asmdef.html) for more information on the rest of the fields in the file!

#### Sample Code - `Editor/EditorExample.cs`

A simple `Editor` script.  Since it's obviously just a sample file, it's recommended to delete this code.



## `Tests`, and its subfolders

This folder and its two subfolders, `Tests/Editor` and `Tests/Runtime`, is intended for any unit tests validating the functionality of scripts in the `Runtime` and `Editor` folder.  As their name implies, `Tests/Editor` runs tests in the Unity editor itself, while `Tests/Runtime` sets up a new scene to run any runtime tests.  Where possible, it's actually recommended to throw as many unit tests in the `Tests/Editor` as possible, *even* if they're testing scripts from the `Runtime` folder, so long as the tested script does not have to be attached to a `GameObject` or rely on an existence of a scene.  Tests in this subfolder runs much faster because a scene doesn't need to be setup for it.  Typically, `MonoBehaviors` and `Components` are the only scripts that are tested in the `Tests/Runtime` folder.  See [Unity's documentation](https://docs.unity3d.com/2019.1/Documentation/Manual/testing-editortestsrunner.html) on unit testing for more details.

If there are no plans to add unit tests into this project (e.g. plugins that already have one in a separate project), it is safe to delete this folder and its content.  Alternatively, if there are no plans to run tests in the `Runtime` scope, the subfolder, `Tests/Runtime` can be safely deleted; same story for `Editor` and `Tests/Editor`.

#### Editor Test Assembly Definition - [`Tests/Editor/OmiyaGames.Template.Editor.Tests.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

If the entire `Tests/Editor` folder and content isn't deleted, this file *must* be renamed and edited.

This is the file that will group the unit tests in the `Tests/Editor` folder into a single C# project, separating it from the rest of the folders in the package, as well as the Unity project when this package gets imported.  The file name, which needs to be unique, should be changed to match either the package's unique identifier with capitalization, or the namespace the scripts are scoped in (preferably both).  Don't forget to add `.Editor.Tests` in the file name to differentiate it from the rest of the assembly definition files.  After renaming the file, the following fields in it should be updated:

- `name`: must be unique from other Assembly Definition files.  Recommended to be updated to match the namespace the scripts are scoped in.
- `references`: list of C# projects the unit tests depends on.  The name of each project should be the same as the `name` field in the Assembly Definition file in said dependencies.  Don't forget to add the `name` of the `Runtime` and/or `Editor` Assembly Definition files in this list as well.

Editing this file can be done in the Unity Inspector window, when the file is selected in the Project window, or a typical text editor.  Note that the fields, `includePlatforms` and `excludePlatforms` should already be set properly.  Furthermore, if the Unity Inspector is used to edit this file, do *not* remove `UnityEngine.TestRunner` and `UnityEditor.TestRunner` from the `references` field.  Don't forget to check out [Unity's documentation](https://docs.unity3d.com/Manual/cus-asmdef.html) for more information on the rest of the fields in the file!

#### Editor Sample Unit Test - `Tests/Editor/EditorExampleTest.cs`

A simple NUnit test script.  Since it's obviously just a sample file, it's recommended to delete this code.

#### Runtime Test Assembly Definition - [`Tests/Editor/OmiyaGames.Template.Tests.asmdef`](https://docs.unity3d.com/Manual/cus-asmdef.html)

If the entire `Tests/Runtime` folder and content isn't deleted, this file *must* be renamed and edited.

This is the file that will group the unit tests in the `Tests/Runtime` folder into a single C# project, separating it from the rest of the folders in the package, as well as the Unity project when this package gets imported.  The file name, which needs to be unique, should be changed to match either the package's unique identifier with capitalization, or the namespace the scripts are scoped in (preferably both).  Don't forget to add `.Tests` in the file name to differentiate it from the rest of the assembly definition files.  After renaming the file, the following fields in it should be updated:

- `name`: must be unique from other Assembly Definition files.  Recommended to be updated to match the namespace the scripts are scoped in.
- `references`: list of C# projects the unit tests depends on.  The name of each project should be the same as the `name` field in the Assembly Definition file in said dependencies.  Don't forget to add the `name` of the `Runtime` Assembly Definition files in this list as well.
- `includePlatforms`: a list of platforms this project supports.  Keep blank if all platforms should be supported.
- `excludePlatforms`: a list of platforms this project *does not* supports.  Keep blank if all platforms should be supported.

Editing this file can be done in the Unity Inspector window, when the file is selected in the Project window, or a typical text editor.  If the Unity Inspector is used to edit this file, do *not* remove `UnityEngine.TestRunner` and `UnityEditor.TestRunner` from the `references` field.  Don't forget to check out [Unity's documentation](https://docs.unity3d.com/Manual/cus-asmdef.html) for more information on the rest of the fields in the file!

#### Runtime Sample Unit Test - `Tests/Editor/RuntimeExampleTest.cs`

A simple NUnit test script.  Since it's obviously just a sample file, it's recommended to delete this code.

