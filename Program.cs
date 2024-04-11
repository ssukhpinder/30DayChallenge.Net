// See https://aka.ms/new-console-template for more information

using _30DayChallenge.Net.Day1;
using _30DayChallenge.Net.Day2;
using _30DayChallenge.Net.Day3;
using _30DayChallenge.Net.Day4;
using _30DayChallenge.Net.Day5;
using _30DayChallenge.Net.Day6;
using _30DayChallenge.Net.Day7;
using _30DayChallenge.Net.Day8;
using _30DayChallenge.Net.Day9;
using _30DayChallenge.Net.Day10;
using _30DayChallenge.Net.Day11;
using _30DayChallenge.Net.Day13;
using _30DayChallenge.Net.Day14;
using _30DayChallenge.Net.Day15;
using _30DayChallenge.Net.Day16;
using _30DayChallenge.Net.Day17;
using _30DayChallenge.Net.Day18;
using _30DayChallenge.Net.Day19;
using System.Drawing;
using _30DayChallenge.Net;
using _30DayChallenge.Net.Day20;
using _30DayChallenge.Net.Day21;
using _30DayChallenge.Net.Day22;
using _30DayChallenge.Net.Day23;
using _30DayChallenge.Net.Day24;


Console.WriteLine("S.No.\t30 Day .Net Challenge\tTutorial\r\nDay 01\tBoolean Expressions\t\r\nDay 02\tVariable Scope & Logic Control\t\r\nDay 03\tSwitch Constructs\t\r\nDay 04\tFor Loops\t\r\nDay 05\tWhile & do-while\t\r\nDay 06\tString built-in methods\t\r\nDay 07\tString built-in methods Part 2\t\r\nDay 08\tException Handling\t\r\nDay 09\tNull Safety\t\r\nDay 10\tFile Paths\t\r\nDay 11\tHelper Methods - Array\t\r\nDay 12\tAzure Functions\t\r\nDay 13\tConfigureAwait(false)\t\r\nDay 14\tLimit Concurrent Async Operations\t\r\nDay 15\tLazy Initialization\t");
Console.WriteLine("Enter Day value in integer");
int dayValue = Convert.ToInt32(Console.ReadLine());
ChooseFrom30DayChallenge(dayValue);

#region SwitchDay to be executed
static string ChooseFrom30DayChallenge(int value)
{
    return value switch
    {
        (int)_30DayChallengeEnum.Day1 => ExecuteDay1(),
        (int)_30DayChallengeEnum.Day2 => ExecuteDay2(),
        (int)_30DayChallengeEnum.Day3 => ExecuteDay3(),
        (int)_30DayChallengeEnum.Day4 => ExecuteDay4(),
        (int)_30DayChallengeEnum.Day5 => ExecuteDay5(),
        (int)_30DayChallengeEnum.Day6 => ExecuteDay6(),
        (int)_30DayChallengeEnum.Day7 => ExecuteDay7(),
        (int)_30DayChallengeEnum.Day8 => ExecuteDay8(),
        (int)_30DayChallengeEnum.Day9 => ExecuteDay9(),
        (int)_30DayChallengeEnum.Day10 => ExecuteDay10(),
        (int)_30DayChallengeEnum.Day11 => ExecuteDay11(),
        (int)_30DayChallengeEnum.Day12 => ExecuteDay12(),
        (int)_30DayChallengeEnum.Day13 => ExecuteDay13().Result,
        (int)_30DayChallengeEnum.Day14 => ExecuteDay14(),
        (int)_30DayChallengeEnum.Day15 => ExecuteDay15(),
        (int)_30DayChallengeEnum.Day16 => ExecuteDay16(),
        (int)_30DayChallengeEnum.Day17 => ExecuteDay17(),
        (int)_30DayChallengeEnum.Day18 => ExecuteDay18(),
        (int)_30DayChallengeEnum.Day19 => ExecuteDay19(),
        (int)_30DayChallengeEnum.Day20 => ExecuteDay20().Result,
        (int)_30DayChallengeEnum.Day21 => ExecuteDay21(),
        (int)_30DayChallengeEnum.Day22 => ExecuteDay22(),
        (int)_30DayChallengeEnum.Day23 => ExecuteDay23(),
        (int)_30DayChallengeEnum.Day24 => ExecuteDay24(),
        _ => "invalid day"
    };
}
#endregion

#region Day 1 - Expressions

static string ExecuteDay1()
{
    Expressions.CheckEqualityOperator();
    Expressions.CheckEqualityBuiltInMethods();
    Expressions.CheckInEqualityOperator();
    Expressions.CheckComparisonOperator();
    Expressions.CheckBooleanMethods();

    return "Executed Day 1 successfully..!!";
}

#endregion

#region Day 2 - Variable Scope & Logic Control with Code Blocks
static string ExecuteDay2()
{

    CodeBlocksAndScope.VariableInCodeBlock();
    CodeBlocksAndScope.VariableOutCodeBlock();
    CodeBlocksAndScope.VariableAboveCodeBlock();
    CodeBlocksAndScope.VariableAboveCodeBlockv1();

    return "Executed Day 2 successfully..!!";
}

#endregion

#region Day 3 - Switch Constructs

static string ExecuteDay3()
{
    Switch.SwitchExample();
    Switch.ChangeSwitchLabelExample();
    Switch.MultipleSwitchLabelExample();

    return "Executed Day 3 successfully..!!";
}

#endregion

#region Day 4 - For Loops
static string ExecuteDay4()
{
    ForLoops.ForLoopExample();
    ForLoops.BackwardForLoopExample();
    ForLoops.IterationForLoopExample();
    ForLoops.BreakForLoopExample();
    return "Executed Day 4 successfully..!!";
}

#endregion

#region Day 5 - While & do-while
static string ExecuteDay5()
{
    WhileLoop.DoWhileLoopExample();
    WhileLoop.WhileLoopExample();
    WhileLoop.ContinueDoWhileLoopExample();


    return "Executed Day 5 successfully..!!";
}

#endregion

#region Day 6 - String built-in methods
static string ExecuteDay6()
{
    StringMethods.IndexOfExample();
    StringMethods.SubstringExample();
    StringMethods.SubstringExample2();
    return "Executed Day 6 successfully..!!";
}
#endregion

#region Day 7 - String built-in methods Part 2
static string ExecuteDay7()
{
    StringMethodsPart2.IndexOfAnyMethod();
    StringMethodsPart2.LastIndexOfMethod();
    return "Executed Day 7 successfully..!!";
}

#endregion

#region Day 8 - Exception Handling
static string ExecuteDay8()
{
    ExceptionHandling.SimpleExceptionBlock();
    ExceptionHandling.NestedExceptionBlock();

    return "Executed Day 8 successfully..!!";
}

#endregion

#region Day 9 - Null Safety
static string ExecuteDay9()
{
    NullSafety.Unsafe();
    NullSafety.SafeExample();
    return "Executed Day 9 successfully..!!";
}

#endregion

#region Day 10 - File Path
static string ExecuteDay10()
{
    FilePath.DisplayCurrentDirectory();
    FilePath.DisplaySpecialDirectory();
    FilePath.DisplayOSPathCharacters();
    FilePath.DisplayFileExtension();
    return "Executed Day 10 successfully..!!";
}

#endregion

#region Day 11 - Helper Methods  -  Array
static string ExecuteDay11()
{
    ArrayHelperMethods.SortExample();
    ArrayHelperMethods.ReverseSortExample();
    ArrayHelperMethods.ClearExample();
    ArrayHelperMethods.ResizeAndAdd();
    return "Executed Day 11 successfully..!!";
}

#endregion

#region Day 12 - Azure Functions
static string ExecuteDay12()
{
    // Set the Azure Function Example as startup project and run locally.
    // The class created under Day 12 folder is for demonstration purposes, cannot be invoked from console application.
    // Follow the tutorial : 
    return "Executed Day 12 successfully..!!";
}

#endregion

#region Day 13: ConfigureAwait(false)
static async Task<string> ExecuteDay13()
{
    await ConfigureAwait.OldApproach();
    ConfigureAwait.OptimizedApproachAsync().ConfigureAwait(false);
    return "Executed Day 13 successfully..!!";
}

#endregion

#region Day 14: Limit Concurrency
static string ExecuteDay14()
{
    // The idea is to demonstrate the concept, no output for simplicity
    LimitConcurrency.OldApproach(null).ConfigureAwait(false);
    LimitConcurrency.OptimizedApproachAsync(null).ConfigureAwait(false);
    return "Executed Day 14 successfully..!!";
}

#endregion

#region Day 15: Lazy Initialization
static string ExecuteDay15()
{
    Console.WriteLine("Application started.");
    Console.WriteLine("Press any key to use the expensive resource...");
    Console.ReadKey();

    // Accessing the Value property of _lazyExpensiveResource for the first time triggers the initialization.
    new Lazy<ExpensiveObject>().Value.UseResource();

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
    return "Executed Day 15 successfully..!!";
}
#endregion

#region Day 16: In-Memory Cache
static string ExecuteDay16()
{
    Console.WriteLine("Fetching product with ID 1 for the first time:");
    var product = InMemoryCache.GetProductById(1);
    Console.WriteLine($"Product Name: {product.Name}\n");

    Console.WriteLine("Fetching product with ID 1 again:");
    product = InMemoryCache.GetProductById(1); // This time, it should come from the cache
    Console.WriteLine($"Product Name: {product.Name}\n");
    return "Executed Day 16 successfully..!!";
}
#endregion

#region Day 17: Increment Class
static string ExecuteDay17()
{
    IncrementClass.TestIncrementCounter();
    return "Executed Day 17 successfully..!!";
}

#endregion

#region Day 18: AggressiveInlining Attribute
static string ExecuteDay18()
{
    AggressiveInlining.MultiplyByTwo(10);
    AggressiveInlining.MultiplyByTwoWithAggressiveInlining(10);
    return "Executed Day 18 successfully..!!";
}

#endregion

#region Day 19: Stack vs. Heap Allocation
static string ExecuteDay19()
{
    StackVsHeap.InefficientMethod(0);
    StackVsHeap.EfficientMethod(0);
    return "Executed Day 19 successfully..!!";
}

#endregion

#region Day 20: Task vs. Value Task
static async Task<string> ExecuteDay20()
{
    Console.WriteLine("Fetching data with Task...");
    string result = await TaskVsValueTask.FetchDataAsync();
    Console.WriteLine(result);

    Console.WriteLine("Fetching data with ValueTask...");
    string resultValueTask = await TaskVsValueTask.FetchDataValueTaskAsync();
    Console.WriteLine(resultValueTask);

    return "Executed Day 20 successfully..!!";
}

#endregion

#region Day 21: String Comparisons
static string ExecuteDay21()
{
    StringComparisons.BadMethod();
    StringComparisons.GoodMethod();

    return "Executed Day 21 successfully..!!";
}

#endregion

#region Day 22: Array Pool
static string ExecuteDay22()
{

    Console.WriteLine("Demonstrating BAD Method:");
    ArrayPoolExample.BadMethod();
    Console.WriteLine("\nDemonstrating GOOD Method:");
    ArrayPoolExample.GoodMethod();
    return "Executed Day 22 successfully..!!";
}

#endregion

#region Day 23: Span Over Arrays
static string ExecuteDay23()
{

    byte[] largeData = new byte[100]; // Simulate a large data set
    Random rng = new Random();
    rng.NextBytes(largeData); // Populate with random bytes

    // Process using array slice
    byte[] slice = new byte[10]; // Creating a new array for the slice
    Array.Copy(largeData, 10, slice, 0, 10); // Copying data
    SpanOverArray.ProcessData(slice);

    // Process using Span<T>
    Span<byte> span = largeData.AsSpan(10, 10); // Creating a span starting at index 10
    SpanOverArray.ProcessData(span);
    return "Executed Day 23 successfully..!!";
}

#endregion


#region Day 23: Avoid Exceptions in Flow Control
static string ExecuteDay24()
{
    Console.WriteLine("Enter a number:");

    string input = Console.ReadLine();
    AvoidExceptions.BadWay(input);
    AvoidExceptions.GoodWay(input);
    return "Executed Day 24 successfully..!!";
}

#endregion