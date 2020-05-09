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

FIXME: Describe file roles, what needs renaming, content edit, etc!
FIXME: Link to source code and samples documentation.

This file is required; it should not be deleted, moved, or renamed.

### ReadMe - `README.md`

FIXME: Describe file roles, what needs renaming, content edit, etc!

It is recommended not to delete, move, or rename this file.

### Package License - `LICENSE.md`

FIXME: Describe file roles, what needs renaming, content edit, etc!

It is recommended not to delete, move, or rename this file.

### Other Third-Party Licenses - `THIRD PARTY NOTICES.md`

FIXME: Describe file roles, what needs renaming, content edit, etc!

This file may be deleted if this package does not use any resources from third-parties.

### Change Log - `CHANGELOG.md`

FIXME: Describe file roles, what needs renaming, content edit, etc!

It is recommended not to delete, move, or rename this file.

### Ignore File - [`.gitignore`](https://git-scm.com/docs/gitignore#_pattern_format)

The file indicating to the Git version control what files to ignore when reviewing any changes to the project.  The default content held in this project should be fine for most users.  That said, if changes needs to be made, the official documentation on formatting `.gitignore` is available [here](https://git-scm.com/docs/gitignore#_pattern_format).

It is recommended not to delete, move, or rename this file.
