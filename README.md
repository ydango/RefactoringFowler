# Refactoring Fowler
A C# translation from JavaScript of the examples in Martin Fowler's ["Refactoring"](https://martinfowler.com/articles/refactoring-2nd-changes.html) :book:, 2nd Edition

## How the Code is translated
The C# code follows the JavaScript as closely as possible

The C# code should be "good style", specifically [ReSharper](https://www.jetbrains.com/resharper) should have no warnings

## Target Environment
.NET Core 2.1

### Build
* [Visual Studio Code](https://code.visualstudio.com) v1.27+ with [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) v1.16+
* Visual Studio 2017 v15.8+ 
### Dependencies
* C# .NET Core using [SDK](https://www.microsoft.com/net/download) v2.1+
* [NUnit](https://nunit.org) v3.10+

## Testing
Unit testing is vital to refactoring and have been added. The convetion used is that ChapterN's tests are in project ChapterN.Tests

## Installing
### Package Manager (for Test projects)
* Install-Package NUnit -Version 3.10.1
* Install-Package NUnit3TestAdapter -Version 3.10.0
* Install-Package Microsoft.NET.Test.Sdk -Version 15.8.0
* Install-Package coverlet.msbuild -Version 2.3.0

## Continuous Integration
[Appveyor](https://www.appveyor.com) using appveyor.yml for Visual Studio 2017

[![Build status](https://ci.appveyor.com/api/projects/status/v3yc51dovaje1jpw/branch/master?svg=true)](https://ci.appveyor.com/project/ydango/refactoringfowler)

[![Coverage Status](https://coveralls.io/repos/github/ydango/RefactoringFowler/badge.svg?branch=master)](https://coveralls.io/github/ydango/RefactoringFowler?branch=master)
  
[![Build history](https://buildstats.info/appveyor/chart/ydango/refactoringfowler)](https://ci.appveyor.com/project/ydango/refactoringfowler/history)

## License
Using the [MIT](https://opensource.org/licenses/MIT) license, as used by .NET Core
