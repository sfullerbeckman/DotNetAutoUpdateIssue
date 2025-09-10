# Demo Application demonstrating unexpected behavior when .NET updates occur during application runtime
This is a demo application for https://github.com/dotnet/runtime/issues/119550.

## Issue Description:
When our application is left running and a ".NET [version] Update for x64 Client" is installed in the background (typically overnight via Windows Update), the application continues to run without immediate failure. However, once a user interacts with the application the next morning and it attempts to load an assembly that had not yet been loaded during the previous session, we encounter several types of failures:

- The affected portion of the application may appear blank.
- A FileNotFoundException may be thrown.
- In some cases, the entire application crashes.

These behaviors vary depending on how the specific module or feature is implemented, but all seem to stem from the same root cause: the .NET update interferes with the runtime's ability to correctly load assemblies that were not previously loaded before the update.
