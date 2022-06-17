using Udemy;
using System.Diagnostics;
using static System.Console;
var timer = new Stopwatch();

#region SumZero

//var wrapper = new SumZero();
//Console.WriteLine($"1 # {wrapper.Problem}");

//Step.Track(wrapper.Naive, ref timer);
//WriteLine(String.Join(",", wrapper.Output!));
//WriteLine($"{timer.ElapsedMilliseconds} ms\n");

//Step.Track(wrapper.Proper, ref timer);
//WriteLine(String.Join(",", wrapper.Output!));
//WriteLine($"{timer.ElapsedMilliseconds} ms\n");

#endregion

#region Same

//var wrapper = new Same();
//Console.WriteLine($"2 # {wrapper.Problem}");

//wrapper.InvalidData();

//Step.Track(wrapper.Naive, ref timer);
//WriteLine(wrapper.Output!.Value);
//WriteLine($"{timer.ElapsedMilliseconds} ms\n");

//Step.Track(wrapper.Proper, ref timer);
//WriteLine(wrapper.Output!.Value);
//WriteLine($"{timer.ElapsedMilliseconds} ms\n");

#endregion

#region MaxSubArraySum

//var wrapper = new MaxSubArraySum();
//Console.WriteLine($"3 # {wrapper.Problem}");

//Step.Track(wrapper.Naive, ref timer);
//WriteLine(String.Join(",", wrapper.Output!));
//WriteLine($"{timer.ElapsedMilliseconds} ms\n");

//Step.Track(wrapper.Proper, ref timer);
//WriteLine(String.Join(",", wrapper.Output!));
//WriteLine($"{timer.ElapsedMilliseconds} ms\n");

#endregion

#region CountUniqueNumbers

//var wrapper = new CountUniqueNumbers();
//Console.WriteLine($"4 # {wrapper.Problem}");

//Step.Track(wrapper.Proper, ref timer);
//WriteLine(String.Join(",", wrapper.Output!));
//WriteLine($"{timer.ElapsedMilliseconds} ms\n");

#endregion

#region Anagram

var wrapper = new Anagram();
Console.WriteLine($"5 # {wrapper.Problem}");

Step.Track(wrapper.Proper, ref timer);
WriteLine(wrapper.Output);
WriteLine($"{timer.ElapsedMilliseconds} ms\n");

#endregion