# Change Log:

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
