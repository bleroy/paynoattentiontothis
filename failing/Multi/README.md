This is a multi-project solution for a library.  In this scenario, there is:

- A core library project
- A fluent C# consumer of that library
- A fluent F# consumer of that library

This will fail to restore.  Here's the repro.

1. Navigate to the solution (`Multi/`).
2. Run `dotnet restore`.

**Expected:** Restore succeeds.

**Actual:**

```
Errors in C:\Users\phcart\Documents\repos\paynoattentiontothis\failing\Multi\MyAwesomeLibrary.CSharp\src\CSharp\project.json
    Unable to resolve 'MyAwesomeLibrary.Core (>= 1.0.0)' for '.NETStandard,Version=v1.5'.

Errors in C:\Users\phcart\Documents\repos\paynoattentiontothis\failing\Multi\MyAwesomeLibrary.CSharp\test\CSharp.Tests\project.json
    Unable to resolve 'MyAwesomeLibrary.CSharp (>= 1.0.0)' for '.NETCoreApp,Version=v1.0'.

Errors in C:\Users\phcart\Documents\repos\paynoattentiontothis\failing\Multi\MyAwesomeLibrary.FSharp\test\FSharp.Tests\project.json
    Unable to resolve 'MyAwesomeLibrary.FSharp (>= 1.0.0)' for '.NETCoreApp,Version=v1.0'.

Errors in C:\Users\phcart\Documents\repos\paynoattentiontothis\failing\Multi\MyAwesomeLibrary.Core\test\Core.Tests\project.json
    Unable to resolve 'MyAwesomeLibrary.Core (>= 1.0.0)' for '.NETCoreApp,Version=v1.0'.

Errors in C:\Users\phcart\Documents\repos\paynoattentiontothis\failing\Multi\MyAwesomeLibrary.FSharp\src\FSharp\project.json
    Unable to resolve 'MyAwesomeLibrary.Core (>= 1.0.0)' for '.NETStandard,Version=v1.5'.

NuGet Config files used:
    C:\Users\phcart\Documents\repos\paynoattentiontothis\failing\Multi\NuGet.Config
    C:\Users\phcart\AppData\Roaming\NuGet\NuGet.Config
    C:\ProgramData\nuget\Config\Microsoft.VisualStudio.Offline.config
    C:\Users\phcart\Documents\repos\paynoattentiontothis\failing\Multi\MyAwesomeLibrary.FSharp\src\FSharp\NuGet.Config

Feeds used:
    https://dotnet.myget.org/F/cli-deps/api/v3/index.json
    https://api.nuget.org/v3/index.json
```
