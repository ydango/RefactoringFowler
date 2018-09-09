# Refactoring Fowler
A C# translation from JavaScript of the examples in Martin Fowler's "Refactoring" book, 2nd Edition

## How the Code is translated
The C# code follows the JavaScript as closely as possible
The C# code should be "good style", specifically [ReSharper](https://www.jetbrains.com/resharper) should have no warnings

## Target Environment
* [Visual Studio Code](https://code.visualstudio.com) v1.27+
* C# .NET Core using [SDK](https://www.microsoft.com/net/download) v2.1+
* [NUnit](https://nunit.org) v3.10+

## Testing
Unit testing is vital to refactoring and have been added even where Fowler didn't include them (using a Class_Test.cs naming convention). In real life it's often better to separate Unit Tests into separate modules but for the purposes of learning from Fowler's book I think close proximity of the Test code to the Class under test helps.

## License
Using the [MIT](https://opensource.org/licenses/MIT) license, as used by .NET Core
