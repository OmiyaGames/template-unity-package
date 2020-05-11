# Adding Importable Assets

This part of the manual pertains to the following folders and files:

```
<root>
  ├── package.json
  └── Samples~
      └── Example1
          └── Example.txt
```

Per [Unity's documentation](https://docs.unity3d.com/Manual/CustomPackages.html), technically, the only required files in this section is `package.json` and at least one folder.  Furthermore, all folders do *not* have to be named the way they are, or put into hierarchy the way they are.  As Unity has not documented on their recommendation of where to place importable assets, `Samples~` will be used for this section, as the trailing `~` hides the folder from Unity Project Window's view.

Note that if the project does *not* contain any importable assets, the folder `Samples~`, its subfolder, and content can be deleted safely.  Do not forget to update the `package.json` file accordingly, as detailed at the bottom of this section.

This section will assume the developer *will* rename a few folders an files, and describe how to update the package to work with the new folder naming-scheme:

## `Samples~` folder

This folder is intended contain assets that can be importaed from the Unity Package Manager window.  As a demonstration, the template contains one subfolder, `Example1`.  Since it and its content is obviously just a sample asset, it's recommended to delete this folder and update the Package Manifest accordingly (see the end of this section on how).

If it hasn't been done so already, it's highly recommended to configure the Unity Editor to generate meta files.  For more information on Unity meta file settings, see [Unity's documentation](https://docs.unity3d.com/2019.1/Documentation/Manual/class-EditorManager.html) on Editor Manager.

![Samples List](https://omiyagames.github.io/template-unity-package/resources/samples.png)

As seen in the screenshot above, the Unity Package Manager allows the package maintainer to list different groups of assets to import separately from one another (e.g. required assets vs. sample demonstrations).  As such, it's recommended to categorize each importable assets first.  From there, simply create a subfolder for each category, and copy or move any assets belonging in that category into the new subfolder.  Since the `Samples~` folder is hidden in the Unity Project window, this *must* be done in a file manager, e.g. Finder on Mac OSX.  Remember when copying or moving any importable assets from the Unity project to a `Samples~` subfolder, the meta file with matching file name should be copied/moved into the same subfolder as well for maximum compatibility.  Finally, do note that subfolders in `Samples~` can have more nested subfolders, if the package maintainer so desires.  When the assets get imported, the hierarcy of these subfolders will be copied over as well.

Once this is all finished, the Package Manifest **MUST** be updated to recognize these new subfolders (see below).

## Package Manifest - [`package.json`](https://docs.unity3d.com/Manual/upm-manifestPkg.html)

This file is required: it should not be deleted, moved, or renamed.  That said, it *must* be edited.

The Package Manifest file is a text file in JSON format storing details about the package that the Package Manager can use to display and categorize the project.  This section will only focus on one field: the `samples` field.  As of this writing, Unity does allow editing this field through its Inspector window: the file *must* be updated with a text editor.  For more information about this file, check out Unity's [own documentation](https://docs.unity3d.com/Manual/upm-manifestPkg.html)!

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
This field is optional, and if this package does not contain any importable assets, can be safely removed.  If it *does*, this field should be updated.

As the name implies, `samples` is the details of each group of importable assets, split by subfolders.  By default, this template lists the `Samples~/Example1` folder it came with.  The field takes in a list of objects, each with the following fields:

- `displayName`: the human-readable name listed next to the "Import to Project" button.
- `description`: the description of the group of assets to import.
- `path`: the path to the folder where this group of assets are held in.  The path is relative to the root of the package, and the folder names should be divided with a `/`, *regardless* of what operating system the package is developed in.

If, for example, there are two sample folders, `Samples~/Required` and `Samples~/Examples`, this field could be edited as follows:
```json
"samples": [
  {
    "displayName": "Required Assets",
    "description": "Assets required to make this package work",
    "path": "Samples~/Required"
  },
  {
    "displayName": "Examples",
    "description": "Examples assets that demonstrates how this package works.",
    "path": "Samples~/Examples"
  }
]
```
As of this writing, this field is not documented in Unity's official documentation yet.  Most likely, it means this field is still in experimental phases, and may change in the future.
