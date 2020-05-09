# Customizing Package

This part of the manual pertains to the following folders and files:

```
<root>
  ├── package.json
  ├── README.md
  ├── CHANGELOG.md
  ├── LICENSE.md
  ├── THIRD PARTY NOTICES.md
  └── .gitignore
```

Per [Unity's documentation](https://docs.unity3d.com/Manual/CustomPackages.html), technically, the only required file in this section is `package.json`.  Nonetheless, this template follows the standard set by [Unity's documentation](https://docs.unity3d.com/Manual/cus-layout.html) to keep things consistent with other packages.  Plus, filling out the following files should help other developers better understand the purpose of the package:

### Package Manifest - [`package.json`](https://docs.unity3d.com/Manual/upm-manifestPkg.html)

This file is required: it should not be deleted, moved, or renamed.  That said, it *must* be edited.

The Package Manifest file is a text file in JSON format storing details about the package that the Package Manager can use to display and categorize the project.  Note that this file *can* be edited inside the Unity Inspector like any other asset files, as opposed to editing it in the text editor; Unity even provides a nice UI for it.  Furthermore, Unity's [own documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html) is quite extensive, so this section will only cover a couple of important fields:

#### `name`
```
  "name": "com.omiyagames.template",
```
This field is required, and *must* be changed.

The `name` field is a unique identifier differentiating this package from potentially other packages with similar display names.  The string stored in this field should follow the classic `com.<company-name>.<package-name>` format.  Furthermore, it's recommended to keep the string below 50 characters in length.  For more information, check out [Unity's documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html#name).

#### `version`
```
  "version": "0.1.0-preview.1",
```
This field is required.  Changing it is recommended, but not necessary.

The `version` field informs the Unity Package Manager what version this package is on.  If a service like [OpenUPM](openupm.com) is being used, this field further informs the Package Manager if the package is in need of an update.  Unity provides a pretty thorough explanation of [how this field should be filled in](https://docs.unity3d.com/Manual/upm-semver.html), but the classic `<major>.<minor>.<patch>` should suffice here.  If in preview, don't forget to add `-preview.<patch>` as well.

#### `displayName`
```
  "displayName": "Omiya Games - Template Unity Package",
```
While technically not required, this field should kept, and more importantly, *changed.*

When the Unity Package Manager displays the name of this package, `displayName` is the field it'll use.  Simply provide a human-friendly name for this package to this field.

#### `description`
```
  "description": "This is a template package, used as a basis to build a bigger one.",
```
While technically not required, this field should kept, and more importantly, *changed.*

When the Unity Package Manager displays a description of this package when selected, `description` is the field it'll use.  Simply provide a human-friendly description for this package to this field.  Note that UTF-8 characters are supported via `\u2603` and `\n`.

#### `unity`
```
  "unity": "2019.3",
```
While technically not required, this field should kept.  Changing it is recommended, but not necessary.

Indicates the lowest version of Unity this package supports.  If patch release info is necessary as well (e.g. Unity 2019.3.7f3), the last set of digits can be added to `unityRelease` field.

#### `type`
```
  "type": "tool",
```
Optional, and only used internally as of this writing.  Changing it is recommended, but not necessary.

Indicates the type of this package.  As of this writing, values Unity recognizes are:
- tool
- library
- module
- template
- sample
- tests

Per [Unity's documentation](https://docs.unity3d.com/Manual/CustomPackages.html), technically, the only required file in this section is `package.json`.  Nonetheless, this template follows the standard set by [Unity's documentation](https://docs.unity3d.com/Manual/cus-layout.html) to keep things consistent with other packages.  Plus, filling out the following files should help other developers better understand the purpose of the package:

#### `dependencies`
```
  "dependencies": {
    "com.unity.ext.nunit": "1.0.0"
  },
```
This field is optional, and if this package does not contain any code or plugins, can be safely removed.  If it *does*, this field should be updated to the code's requirements.

As the name implies, `dependencies` is a list of packages this project relies on.  The list of object parameters should be listed in `"<package-unique-identifier>": "<supported-version-of-package>"`.

As this field is critical for adding compiling source code to the package, more information is available at the [Adding Source Code and Assets](https://omiyagames.github.io/template-unity-package/manual/customizeSource.html) section of this manual.

#### `samples`
```
  "samples": [
    {
      "displayName": "Example 1",
      "description": "This sample is just an example",
      "path": "Samples~/Example1"
    }
  ]
```
This field is optional, and if this package does not contain assets users can import, can be safely removed.  If it *does*, this field should be changed to the package's director setup.

Unity Package Manager provides an option for packages to list one or more "Import to project" buttons, which naturally allows the user to import assets into their project.  To specify what gets imported, the `samples` field contains a list of objects, each holding the `displayName`, `description`, and `path` (relative to the root of the package's directory) fields.

As this field is critical for adding importable assets to the package, more information is available at the [Adding Importable Assets](https://omiyagames.github.io/template-unity-package/manual/customizeSamples.html) section of this manual.

### ReadMe - `README.md`

It's recommended to edit this file.

As the name of the file implies, `README.md` is a Markdown file intended to inform first-time viewers of this package's source what the purpose of the package is, and provide guidance on maintainers where the important files are.  It has the added bonus that most online repository websites displays this Markdown file as an in-depth description of the project as a whole.

### Package License - `LICENSE.md`

It's recommended to edit this file.

As the name of the file implies, `LICENSE.md` is a Markdown file describing the license of the package overall.  It has the added bonus that some open-source-encouraging online repository websites uses this file to indicate developers the license of the project.  If there are assets borrowed from third-party sources, it is recommended to list those in `THIRD PARTY NOTICES.md`.

### Other Third-Party Licenses - `THIRD PARTY NOTICES.md`

If the package does not contain any third-party assets, this file may be safely removed.  Otherwise, it's highly recommended to edit this file.

`THIRD PARTY NOTICES.md` is a Markdown file that informs the reader what assets comes from third-party sources, and what the license of those assets are.

### Change Log - `CHANGELOG.md`

It's recommended to edit this file.

`THIRD PARTY NOTICES.md` is a Markdown file listing all the past versions of this package, and how the package has changed.  Each time a new release is being prepared, this file should be updated with the latest information.

### Ignore File - [`.gitignore`](https://git-scm.com/docs/gitignore#_pattern_format)

It's recommend to keep this file; feel free to make edits to it for your own purpose.

The Git version control uses this `.gitignore` text file to determine what files to ignore when the application reviews any changes to the project.  The default content held in this project should be fine for most Unity users.  That said, if changes needs to be made, the official documentation on formatting `.gitignore` is available [here](https://git-scm.com/docs/gitignore#_pattern_format).
