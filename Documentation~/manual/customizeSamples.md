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

This section will assume the developer *will* rename a few folders, and describe how to update the package to work with the new folder naming-scheme:

### Package Manifest - [`package.json`](https://docs.unity3d.com/Manual/upm-manifestPkg.html)

FIXME: Describe file roles, and what fields are relevant for this section.

This file is required; it should not be deleted, moved, or renamed.

## Samples~ folder

FIXME: describe how to add files here.
