# Change Log:

## 1.4.4

- Enhancement: Updating `package.json` version number to `1.0.0-pre.1`, per latest Unity standard.
- Enhancement: Updating documentation to the latest folder structure and content specs, such as linking to the `Samples~` section in the Unity's documentation instead of saying, "as of this writing, there is no official documentation" (when there obviously is, now.)
- Bug Fix: forgot to ignore `Documentation~/index.md`.

## 1.4.3

- Enhancement: restructuring the documentation so that the [`README.md`](/README.md) at the root of the project becomes the homepage of the DocFX-generated documentation.  The old `index.md` has now been added to `Documentation~/manual` folder, as the first page describing the content of this package.  This should make updating documentation easier for future projects, as only the `README.md` file needs to be updated to change the homepage.
- Enhancement: extending license year to 2022

## 1.4.2

- Enhancement: adding conditionals to [`.github/workflows/documentation.yml`](/.github/workflows/documentation.yml) and [`.github/workflows/mirror.yml`](/.github/workflows/mirror.yml) to prevent the jobs from running on other repos copying this template automatically.  Added comments, and updated documentation indicating these conditional's purpose, and how to remove them.

## 1.4.1

- Enhancement: changing the mirror action to [this one](https://github.com/marketplace/actions/mirroring-repository).

## 1.4.0

- Feature: added Github Action to mirror the repository to [`Bitbucket`](https://bitbucket.org/OmiyaGames/template-unity-package) automatically.  This new file is available here: [`.github/workflows/mirror.yml`](/.github/workflows/mirror.yml).
- Enhancement: updated [Customize Package manual](https://omiyagames.github.io/template-unity-package/manual/customizePackage.html) talking about what files from `.github` can be deleted or edited.

## 1.3.1

- Typo: Fixed the documentation build status badge in [`README.md`](/README.md).

## 1.3.0

- Feature: added Github Action to auto-generate documentation in the [`Documentation~`](/Documentation~) folder using [DocFX for Unity](https://github.com/NormandErwan/DocFxForUnity) project as reference.
- Feature: adding Github feature, sponsorship!  The `FUNDING.yml` file in `.github` folder adds a sponsorship button on Github with a link to [Ko-Fi](https://ko-fi.com/omiyagames).
- Enhancement: Updated [`README.md`](/README.md) to link to the newly-generated documentation, and provide better installation instructions.

## 1.2.2

- Enhancement: making the platform [`OmiyaGames.Template.Editor.asmdef`](/Editor/OmiyaGames.Template.Editor.asmdef) and [`OmiyaGames.Template.Editor.Tests.asmdef`](/Tests/Editor/OmiyaGames.Template.Editor.Tests.asmdef) supports to only the editor.

## 1.2.1

- Rename: `EditorExampleTest.cs` to [`TestEditorExample.cs`](/Tests/Editor/TestEditorExample.cs). Updated class name along with it.
- Rename: `RuntimeExampleTest.cs` to [`TestRuntimeExample.cs`](/Tests/Editor/TestRuntimeExample.cs). Updated class name along with it.
- Typo: Removed `[CustomEditor(typeof(RuntimeExample))]` attribute from [`EditorExampleTest.cs`](/Tests/Editor/TestEditorExample.cs). It serves no purpose.
- Typo: Removed `[CustomEditor(typeof(RuntimeExample))]` attribute from [`EditorExampleTest.cs`](/Tests/Editor/TestEditorExample.cs). It serves no purpose.

## 1.2.0

- Feature: Updated the [`Tests`](/Tests) assembly definition files and example scripts with proper configuration for editing/creating new unit test scripts. Also updated [`package.json`](/package.json) with NUnit as a required dependency.
- Enhancement: Added significantly more information in [`README.md`](/README.md) so other people can use a more fleshed-out markdown format to start their documentation.
- Enhancement: Changing [`package.json`](/package.json) into a type -> Tool, and added one more keyword.
- Enhancement: Noting [`THIRD PARTY NOTICES.md`](/THIRD%20PARTY%20NOTICES.md) is just an example, and this project doesn't actually use any 3rd party tools yet (besides unit testing, but I think that's already implied).

## 1.1.0

- Feature: adding a [`Documentation~/Doxyfile`](/Documentation~/Doxyfile) to make generating [Doxygen](http://doxygen.nl/) files a little easier.

## 1.0.2

- Typo: renaming `Documentation~/index.md` to [`Documentation~/Template.md`](/Documentation~/Template.md) to match Unity recommendation.

## 1.0.1

- Bug fix: [`Editor/EditorExample.cs`](/Editor/EditorExample.cs) now compiles properly.
- Typo: updated namespace in [`Tests/Editor/EditorExampleTest.cs`](/Tests/Editor/EditorExampleTest.cs) to inlucde `Test`.
- Typo: changing the [`THIRD PARTY NOTICES.md`](/THIRD%20PARTY%20NOTICES.md) Credits section to use a list, so each field is in its own line.

## 1.0.0

- Initial release:
    - Confirmed the template project works by battle-testing it to [Omiya Games - Common](https://github.com/OmiyaGames/omiya-games-common) package.
- Updated every text to be more generic.
