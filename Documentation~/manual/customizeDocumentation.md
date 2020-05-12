# Customizing Documentation

This part of the manual pertains to the following folders and files:

```
<root>
  ├── Documentation~
  |   ├── index.md
  |   ├── Doxyfile
  |   ├── docfx.json
  |   ├── toc.yml
  |   ├── filterConfig.yml
  |   ├── manual
  |   |   ├── toc.yml
  |   |   ├── customizeDocumentation.md
  |   |   ├── customizePackage.md
  |   |   ├── customizeSamples.md
  |   |   └── README.md
  |   └── resources
  |       ├── preview.png
  |       └── README.md
  └── .github
      └── workflows
          └── documentation.yml
```

Despite [Unity's recommendation](https://docs.unity3d.com/Manual/cus-layout.html), technically the folders and files in this entire section are optional.  That said, this project aims to take advantage of two things:

1. Automate generating documentation through [Github Actions](https://help.github.com/en/actions/getting-started-with-github-actions/about-github-actions), [DocFX](https://dotnet.github.io/docfx/), and [C# comments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/recommended-tags-for-documentation-comments), and
2. Hide the documentation from Unity Project window's view, by using a trailing `~` in the folder name.

This section covers how to update these files to generate the documentations to your own liking.  Note that the source for most of this information comes from the open-source [DocFX for Unity](https://github.com/NormandErwan/DocFxForUnity) project.

## Github Action Support

Files in the `.github` folder are intended for Github-specific features, including automation features under `workflows` folder.  Obviously, if the repo is *not* hosted on Github, or the developer does not plan to take advantage of some of these features, this folder and its content may be safely deleted.

Naturally, the Github Actions held in the `workflows` folder needs a little setup for them to work.  The following sections will cover each one, what they do, and what preparations the developer needs to make.  If similar alternatives exists for other Git repository hosts, this document will do its best to list them.

### `.github/workflows/documentation.yml`

The `documentation.yml` file automates generating documentation using DocFX.  The full documentation on what each field means is available on [Github's website](https://help.github.com/en/actions/configuring-and-managing-workflows/configuring-a-workflow), but this section will only cover a small part of the file.

#### `if:` lines

To prevent this action from running on every repository that copies or forks this template, an `if` line and conditional is added at two jobs in `documentation.yml`, and look like this:

```yaml
if:    # Adding if-statement to prevent this job from running on packages using this template.
       # If you want to run this documentation job, just take out the if-field and value below.
  github.repository == 'OmiyaGames/template-unity-package'
```

As the comments imply, if the developer wants Github to automatically generate their documentation, they should remove these lines.

#### `name: Build` line

The `Build` line is probably where most developers would be most interested in:

```yaml
- name: Build
  run: |
    cp CHANGELOG.md Documentation~/manual/changelog.md
    docfx Documentation~/docfx.json
```

The `run` string describes the Batch commands that gets run in a windows VM.  As one can see, the above line copies the `CHANGELOG.md` file into `Documentation~/manual/changelog.md`, before running the `docfx` command at the last line to generate the documentation.  This multiline string can be updated to copy or change other documentation files.  For example, the developer may want to copy the `README.md` file at the root of the package to  `Documentation~/manual/index.md`, so that when DocFX runs, the homepage will look exactly like the `README.md` file.  In that case, it would be helpful to edit this file as:

```yaml
- name: Build
  run: |
    cp README.md Documentation~/manual/index.md
    cp CHANGELOG.md Documentation~/manual/changelog.md
    docfx Documentation~/docfx.json
```

Of course, if the developer chooses to make this edit, they should also delete the `Documentation~/manual/index.md` file, and add a line in `.gitignore` to ignore this file.

After this line is updated to the developer's satisfaction, the repository must be configured to provide the Github access to the repo itself.

### Creating Secret Access Key

To give Github Actions access to the package's repository, a private key must be created and shared.

1. If the developer hasn't done this step already, go to ["Settings -> Developer Settings -> Personal access token,"](https://github.com/settings/tokens) and generate a new token with full access to `repo`.  Don't forget to copy the secret key printed on the new entry in a safe location.
   - ![Personal Access Token](https://omiyagames.github.io/template-unity-package/resources/personalAccessToken.png)
2. Return to the Github repository, then go to "Settings -> Secrets," and add the generated key into the list.  Remember to name this key as, `AccessToken`.
   - ![Add Secret](https://omiyagames.github.io/template-unity-package/resources/addingSecrets.png)
3. Finally, push the repository to the master branch to deploy the automated commands!  A new breanch, `gh-pages`, and website, `https://<username>.github.io/<repo-name>/` will be created as part of this process.

For more information, check the [Github Pages Deploy Action documentation](https://github.com/JamesIves/github-pages-deploy-action).

## DocFX Support

[DocFX](https://dotnet.github.io/docfx/) allows generating documentation from Markdown files and comments in C# scripts.  This project configures DocFX to generate a website with a similar layout as Unity's own packages: a documentation split between "Manual," generated from Markdown files in the `manual` folder, and "Scripting API," generated from comments in C# scripts.  To customize the generated site, especially the Manual, the following files and folders should be reviewed:

### `Documentation~/docfx.json`

`docfx.json` is a JSON file containing the configuration for the generator to read.  This portion of this manual will only concern itself with fields a package developer will likely want to edit, but for the full documentation on this file, do check out [DocFX's documentation](https://dotnet.github.io/docfx/tutorial/docfx.exe_user_manual.html#3-docfxjson-format) on it.  It provides extra information, such as how to edit the theme of the generated website.

There are two fields the developer will probably want to edit:

#### `globalMetadata`

`globalMetadata` refers to this part in the `docfx.json` files:
```json
"globalMetadata": {
    "_appTitle": "Template Unity Package documentation",
    "_appFooter": "Copyright © 2020 Omiya Games",
    "_enableSearch": true
},
```
As one can probably guess from the object's key names, the value under `_appTitle` is printed at the top of the website, and the value under `_appFooter` is printed at the bottom as a footer.  It's obviously recommended to change these values to what matches with the developer's package name and company respectively.

#### `sitemap`

`sitemap` refers to this part in the `docfx.json` files:
```json
"sitemap":
{
    "baseUrl": "https://omiyagames.github.io/template-unity-package/",
    ...
},
```
While this field has many keys, changing the `baseUrl` is important because it siginifies to the sitemap generator what the base URL for the generated site is going to be.  Obviously, this should be changed to the URL your documentation is going to be generated in (e.g. for Github, `https://<username>.github.io/<repo-name>/`).  Note the trailing `/` is necessary.

### `Documentation~/filterConfig.yml`

`filterConfig.yml` is a YAML file DocFX uses to filter in or out C# code to generate the "Scripting API" portion of the documentation.  The full documentation on this file is [available here](https://dotnet.github.io/docfx/tutorial/howto_filter_out_unwanted_apis_attributes.html).  The part that the package developer needs to change is the list of [regular expressions](https://regexr.com/) that is used to match C# scripts defined under certain namespaces.  As one can see below, by default, the template package filters in `OmiyaGames.Template`, `OmiyaGames.Template.Editor`, or global namespace.
```yaml
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
The developer should change `^OmiyaGames\.Template$` and `^OmiyaGames\.Template\.Editor$` to match their scripts' namespaces, perhaps even remove some include list items if not necessary.  Since these are regular expressions, wildcards like `*` may be used.

### `Documentation~/index.md`

`index.md` is the Markdown file DocFX uses to generate the homepage of the documentation.  Obviously, the package developer should edit it to introduce the reader to their package.  Alternatively, one may also chose to delete this file, and edit `.github/workflows/documentation.yml` to copy the package's `README.md` to `Documentation~/index.md` automatically instead.

### Files in `Documentation~/manual/`

As the `README.md` file under this folder mentions, the `manual` folder is where the package developer can create a number of markdown files to add under the "Manual" portion of the documentation.  Obviously, it's recommended for the developer to delete all the files ending in `*.md`, and replace them with their own Markdown files to describe how to use their package.  If the Markdown file needs to reference a media file, such as images, they can be added into the `Documentation~/resources/`, which is detailed later.  Once the documentation is finished, the table of contents file must be updated, which leads us to...

#### `Documentation~/manual/toc.yml`

`toc.yml` is the table of contents YAML file that supports formatting that looks like this:
```yaml
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
As demonstrated in the example above, DocFX table of contents support multiple hierarchies through the `items` field.  Other than that, `name` field is the displayed text as a bullet point, while `href` is either a URL to another website, or a path to a markdown file local to the `toc.yml` file.  The full documentation on this file is [available here](https://dotnet.github.io/docfx/tutorial/intro_toc.html).

Obviously, once the manual documentation is updated, this file should be updated as well to indicate which markdown files should be read to generate the manual.

### Files in `Documentation~/resources/`

`resources` is a folder the developer can add media files to, to better enhance their `manual` Markdown files with images and so forth.  Obviously, the entire content of this folder can be deleted and replaced with what's necessary for the documentation's "Manual."

## Doxygen Support

Apart from DocFX, the `Documentation~` folder also contains a `Doxyfile` that, with only a few edits, can be used by [Doxygen](http://doxygen.nl/) to generate documentation from the C# scripts in the package.

### `Documentation~/Doxyfile`

`Doxyfile` is a massive text file containing configuration settings for Doxygen's Doxywizard, which then reads the comments from the package's C# scripts and generated a website.  This section will cover only a few fields to update as bare-minimum setup, but the full documentation is [available here](http://www.doxygen.nl/manual/index.html).

#### `PROJECT_NAME`

The `PROJECT_NAME` field is what gets displayed on the top of the generated webpage:
```
PROJECT_NAME           = "Omiya Games - Template Unity Package"
```
Obviously, the value of this field should be changed to the package's name.

#### `PROJECT_NUMBER`

The `PROJECT_NUMBER` field is the identifier of the project.
```
PROJECT_NUMBER         = com.omiyagames.template
```
The value of this field should be changed to the unique identifier of the package (e.g. the `name` field in `package.json`).

#### `PROJECT_BRIEF`

Latly, the `PROJECT_BRIEF` field refers to the subtitles appearing below the `PROJECT_NAME`.
```
PROJECT_BRIEF          = "Just a template, acting as a useful starting point to develop a Unity package."
```
Naturally, this value should be changed to a brief description of the package.
