// See https://aka.ms/new-console-template for more information

using _30DayChallenge.Net.Day1;
using _30DayChallenge.Net.Day10;
using _30DayChallenge.Net.Day11;
using _30DayChallenge.Net.Day13;
using _30DayChallenge.Net.Day2;
using _30DayChallenge.Net.Day3;
using _30DayChallenge.Net.Day4;
using _30DayChallenge.Net.Day5;
using _30DayChallenge.Net.Day6;
using _30DayChallenge.Net.Day7;
using _30DayChallenge.Net.Day8;
using _30DayChallenge.Net.Day9;

#region Day 1 - Expressions

Expressions.CheckEqualityOperator();
Expressions.CheckEqualityBuiltInMethods();
Expressions.CheckInEqualityOperator();
Expressions.CheckComparisonOperator();
Expressions.CheckBooleanMethods();

#endregion

#region Day 2 - Variable Scope & Logic Control with Code Blocks

CodeBlocksAndScope.VariableInCodeBlock();
CodeBlocksAndScope.VariableOutCodeBlock();
CodeBlocksAndScope.VariableAboveCodeBlock();
CodeBlocksAndScope.VariableAboveCodeBlockv1();

#endregion

#region Day 3 - Switch Constructs

Switch.SwitchExample();
Switch.ChangeSwitchLabelExample();
Switch.MultipleSwitchLabelExample();

#endregion

#region Day 4 - For Loops

ForLoops.ForLoopExample();
ForLoops.BackwardForLoopExample();
ForLoops.IterationForLoopExample();
ForLoops.BreakForLoopExample();

#endregion

#region Day 5 - While & do-while

WhileLoop.DoWhileLoopExample();
WhileLoop.WhileLoopExample();
WhileLoop.ContinueDoWhileLoopExample();

#endregion

#region Day 6 - String built-in methods

StringMethods.IndexOfExample();
StringMethods.SubstringExample();
StringMethods.SubstringExample2();

#endregion

#region Day 7 - String built-in methods Part 2

StringMethodsPart2.IndexOfAnyMethod();
StringMethodsPart2.LastIndexOfMethod();

#endregion

#region Day 8 - Exception Handling

ExceptionHandling.SimpleExceptionBlock();
ExceptionHandling.NestedExceptionBlock();

#endregion

#region Day 9 - Null Safety

NullSafety.Unsafe();
NullSafety.SafeExample();

#endregion

#region Day 10 - File Path

FilePath.DisplayCurrentDirectory();
FilePath.DisplaySpecialDirectory();
FilePath.DisplayOSPathCharacters();
FilePath.DisplayFileExtension();

#endregion

#region Day 11 - Helper Methods  -  Array

ArrayHelperMethods.SortExample();
ArrayHelperMethods.ReverseSortExample();
ArrayHelperMethods.ClearExample();
ArrayHelperMethods.ResizeAndAdd();

#endregion

#region Day 12 - Azure Functions

// Set the Azure Function Example as startup project and run locally.
// The class created under Day 12 folder is for demonstration purposes, cannot be invoked from console application.
// Follow the tutorial link: 

#endregion

#region Day 13: ConfigureAwait(false)

await ConfigureAwait.OldApproach();
ConfigureAwait.OptimizedApproachAsync().ConfigureAwait(false);

#endregion