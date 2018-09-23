# Refactoring Fowler
A C# translation from JavaScript of the examples in Martin Fowler's ["Refactoring"](https://martinfowler.com/articles/refactoring-2nd-changes.html) :book:, 2nd Edition

## How the Code is translated
The C# code follows the JavaScript as closely as possible

The C# code should be "good style", specifically [ReSharper](https://www.jetbrains.com/resharper) should have no warnings

## Target Environment
* [Visual Studio Code](https://code.visualstudio.com) v1.27+ or Visual Studio 2017 v15.8.4+ 
* [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) v1.16.1+
* C# .NET Core using [SDK](https://www.microsoft.com/net/download) v2.1.401+
* [NUnit](https://nunit.org) v3.10.1+

## Testing
Unit testing is vital to refactoring and have been added even where Fowler didn't include them (using a Class_Test.cs naming convention). In real life it's often better to separate Unit Tests into separate modules but for the purposes of learning from Fowler's book I think close proximity of the Test code to the Class under test helps.

## Installing
### Package Manager
* Install-Package NUnit -Version 3.10.1
* Install-Package NUnit3TestAdapter -Version 3.10.0
* Install-Package Microsoft.NET.Test.Sdk -Version 15.8.0

## Continuous Integration
[Appveyor](https://www.appveyor.com) using appveyor.yaml for Visual Studio 2017

## License
Using the [MIT](https://opensource.org/licenses/MIT) license, as used by .NET Core
