# SystemCommandLineStructIssue
Minimal sample for showing the inability to use structs in System.CommandLine:

    $ dotnet build
    MSBuild version 17.4.1+9a89d02ff for .NET
      Determining projects to restore...
      All projects are up-to-date for restore.
    Program.cs(17,37): error CS1503: Argument 2: cannot convert from 'method group' to 'Action<FooStruct?>' [SystemCommandLineIssue.csproj]
    Program.cs(21,36): warning CS8622: Nullability of reference types in type of parameter 'fooClass' of 'void Program.FooClassHandler(FooClass fooClass)' doesn't match the target delegate 'Action<FooClass?>' (possibly because of nullability attributes). [SystemCommandLineIssue.csproj]
    
    Build FAILED.
    
    Program.cs(21,36): warning CS8622: Nullability of reference types in type of parameter 'fooClass' of 'void Program.FooClassHandler(FooClass fooClass)' doesn't match the target delegate 'Action<FooClass?>' (possibly because of nullability attributes). [SystemCommandLineIssue.csproj]
    Program.cs(17,37): error CS1503: Argument 2: cannot convert from 'method group' to 'Action<FooStruct?>' [SystemCommandLineIssue.csproj]
        1 Warning(s)
        1 Error(s)
