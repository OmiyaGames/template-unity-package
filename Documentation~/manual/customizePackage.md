# Customizing Package Files

This part of the manual pertains to the following folders and files:

```
<root>
  ├── package.json
  ├── .github
  |   ├── FUNDING.yml
  |   ├── ISSUE_TEMPLATE
  |   |   ├── bug_report.md
  |   |   ├── feature_request.md
  |   |   ├── documentation-template.md
  |   |   └── research_template.md
  |   └── workflows
  |       └── documentation.yml
  ├── README.md
  ├── CHANGELOG.md
  ├── LICENSE.md
  ├── THIRD PARTY NOTICES.md
  └── .gitignore
```

Per [Unity's documentation](https://docs.unity3d.com/Manual/CustomPackages.html), technically, the only required file in this section is `package.json`.  Nonetheless, this template follows the standard set by [Unity's documentation](https://docs.unity3d.com/Manual/cus-layout.html) to keep things consistent with other packages.  Plus, filling out the following files should help other developers better understand the purpose of the package:

## Package Manifest - [`package.json`](https://docs.unity3d.com/Manual/upm-manifestPkg.html)

This file is required: it should not be deleted, moved, or renamed.  That said, it *must* be edited.

![Unity Package Manager](https://omiyagames.github.io/template-unity-package/resources/preview.png)

The Package Manifest file is a JSON file storing details about the package that the Package Manager can use to display and categorize the project.  Note that this file *can* be edited inside the Unity Inspector like any other asset files, as opposed to editing it in the text editor; Unity even provides a nice UI for it.  Furthermore, Unity's [own documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html) is quite extensive, so this section will only cover a couple of important fields:

### `name`
```
"name": "com.omiyagames.template",
```
This field is required, and *must* be changed.

The `name` field is a unique identifier differentiating this package from potentially other packages with similar display names.  The string stored in this field should follow the classic `com.<company-name>.<package-name>` format.  Furthermore, it's recommended to keep the string below 50 characters in length.  For more information, check out [Unity's documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html#name).

### `version`
```
"version": "1.0.0-pre.1",
```
This field is required.  Changing it is recommended, but not necessary.

The `version` field informs the Unity Package Manager what version this package is on.  If a service like [OpenUPM](openupm.com) is being used, this field further informs the Package Manager if the package is in need of an update.  Unity provides a pretty thorough explanation of [how this field should be filled in](https://docs.unity3d.com/Manual/upm-semver.html), but the classic `<major>.<minor>.<patch>` should suffice here.  If in preview, don't forget to add `-preview.<patch>` as well.

### `displayName`
```
"displayName": "Omiya Games - Template Unity Package",
```
While technically not required, this field should kept, and more importantly, *changed.*

When the Unity Package Manager displays the name of this package, `displayName` is the field it'll use.  Simply provide a human-friendly name for this package to this field.

### `description`
```
"description": "This is a template package, used as a basis to build a bigger one.",
```
While technically not required, this field should kept, and more importantly, *changed.*

When the Unity Package Manager displays a description of this package when selected, `description` is the field it'll use.  Simply provide a human-friendly description for this package to this field.  Note that UTF-8 characters are supported via `\u2603` and `\n`.

### `unity`
```
"unity": "2021.2",
```
While technically not required, this field should kept.  Changing it is recommended, but not necessary.

Indicates the lowest version of Unity this package supports.  If patch release info is necessary as well (e.g. Unity 2019.3.7f3), the last set of digits can be added to `unityRelease` field.

### `type`
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

### `dependencies`
```json
"dependencies": {
  "com.unity.ext.nunit": "1.0.0"
},
```
This field is optional, and if this package does not contain any code or plugins, can be safely removed.  If it *does*, this field should be updated to the code's requirements.

As the name implies, `dependencies` is a list of packages this project relies on.  The list of object parameters should be listed in `"<package-unique-identifier>": "<supported-version-of-package>"`.

As this field is critical for adding compiling source code to the package, more information is available at the [Adding Source Code and Assets](https://omiyagames.github.io/template-unity-package/manual/customizeSource.html) section of this manual.

### `samples`
```json
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

## Github-Specific Features - `.github` Folder

Files in the `.github` folder are intended for Github-specific features, including templates for its bug-tracking system (folder `ISSUE_TEMPLATE`), list of websites to sponsor the package (file `FUNDING.yml`), and automation feature under `workflows` folder.  Obviously, if the repo is *not* hosted on Github, this folder and its content can be safely deleted.  If the developer *does* want to utilize some of the features this template comes with, the purpose of each file or folder will be listed below:

### `.github/workflows/documentation.yml`

This YAML file instructs Github to automatically generate a documentation website.  For those who would like to take advantange of this feature, the [Customizing Documentation](https://omiyagames.github.io/template-unity-package/manual/customizeDocumentation.html) section of this manual covers this file extensively.  Obviously, if the developer has no plans on generating documentation for their package, this file can be safely deleted.

### `.github/FUNDING.yml`

This YAML file adds a "Sponsor" button at the top of an open-source Github repository.  If the developer would like to take advantage of the feature, the comments (text following `#`) on the text file is pretty self-explanatory, and won't be elaborated here.  If the package is not going to be open-source, or in need of sponsoring, this file can be safely removed.

### `.github/ISSUE_TEMPLATE` folder

The markdown files in the `.github/ISSUE_TEMPLATE` holds templates for issues one can file on Github, providing a standard for the issue filer.  As markdown files, the files should be human-readable, and its content won't be futher elaborated on this manual.  As usual, if there's no need for any or all templates in this folder, the folder or individual files themselver may be safely deleted.

## ReadMe - `README.md`

It's recommended to edit this file.

As the name of the file implies, `README.md` is a Markdown file intended to inform first-time viewers of this package's source what the purpose of the package is, and provide guidance on maintainers where the important files are.  It has the added bonus that most online repository websites displays this Markdown file as an in-depth description of the project as a whole.  Lastly, if [`.github/workflows/documentation.yml`](#githubworkflowsdocumentationyml) is configured to generate documentation, it will use `README.md` as the homepage.

## Package License - `LICENSE.md`

It's recommended to edit this file.

As the name of the file implies, `LICENSE.md` is a Markdown file describing the license of the package overall.  It has the added bonus that some open-source-encouraging online repository websites uses this file to indicate developers the license of the project.  If there are assets borrowed from third-party sources, it is recommended to list those in `THIRD PARTY NOTICES.md`.

## Other Third-Party Licenses - `THIRD PARTY NOTICES.md`

If the package does not contain any third-party assets, this file may be safely removed.  Otherwise, it's highly recommended to edit this file.

`THIRD PARTY NOTICES.md` is a Markdown file that informs the reader what assets comes from third-party sources, and what the license of those assets are.

## Change Log - `CHANGELOG.md`

It's recommended to edit this file.

`THIRD PARTY NOTICES.md` is a Markdown file listing all the past versions of this package, and how the package has changed.  Each time a new release is being prepared, this file should be updated with the latest information.

## Ignore File - [`.gitignore`](https://git-scm.com/docs/gitignore#_pattern_format)

It's recommend to keep this file; feel free to make edits to it for your own purpose.

The Git version control uses this `.gitignore` text file to determine what files to ignore when the application reviews any changes to the project.  The default content held in this project should be fine for most Unity users.  That said, if changes needs to be made, the official documentation on formatting `.gitignore` is available [here](https://git-scm.com/docs/gitignore#_pattern_format).
