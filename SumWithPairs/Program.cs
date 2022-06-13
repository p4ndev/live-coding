using SumWithPairsSorted;

Services _ser = new();
Console.WriteLine($"\nFinding a matching pair on {_ser.Format} {_ser.Count} numbers with sum of {_ser.Sum}...\n");

string _res0 = _ser.HasPairSortedOnly() ? "Yes" : "No";
Console.WriteLine($"1 [HasPairSortedOnly] Has found?");
Console.WriteLine($"{_res0} | {(_ser.Ms / 60000)}m | {(_ser.Ms / 1000)}s | {_ser.Ms}ms\n");

string _res1 = _ser.HasPairHashSet() ? "Yes" : "No";
Console.WriteLine("2 [HasPairHashSet] Has found?");
Console.WriteLine($"{_res1} | {(_ser.Ms / 60000)}m | {(_ser.Ms / 1000)}s | {_ser.Ms}ms\n");

string _res2 = _ser.HasPairLinqWhereContains() ? "Yes" : "No";
Console.WriteLine("3 [HasPairLinqWhereContains] Has found?");
Console.WriteLine($"{_res2} | {(_ser.Ms / 60000)}m | {(_ser.Ms / 1000)}s | {_ser.Ms}ms\n");

string _res3 = _ser.HasPairLinqDoubleCount() ? "Yes" : "No";
Console.WriteLine("4 [HasPairLinqDoubleCount] Has found?");
Console.WriteLine($"{_res3} | {(_ser.Ms / 60000)}m | {(_ser.Ms / 1000)}s | {_ser.Ms}ms\n");

//BenchmarkDotNet.Running.BenchmarkRunner.Run<Services>();
