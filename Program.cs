using System.CommandLine;

internal struct FooStruct {}
internal class FooClass {}

internal class Program
{
    private static Option<FooStruct?> GetFooStructOption() =>
        new Option<FooStruct?>("", () => new FooStruct());
    private static Option<FooClass?> GetFooClassOption() =>
        new Option<FooClass?>("", () => new FooClass());

    private static void Main(string[] args)
    {
        var fooStructOption = GetFooStructOption();
        var fooStructCommand = new Command("fooCommand", "") { fooStructOption};
        fooStructCommand.SetHandler(FooStructHandler, fooStructOption);

        var fooClassOption = GetFooClassOption();
        var fooClassCommand = new Command("fooCommand", "") { fooClassOption};
        fooClassCommand.SetHandler(FooClassHandler, fooClassOption);
    }

    private static void FooStructHandler(FooStruct fooStruct) {}
    private static void FooClassHandler(FooClass fooClass) {}
}