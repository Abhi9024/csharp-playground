using BenchmarkDotNet.Running;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
 var summary = BenchmarkRunner.Run<BenchMarkTest>();

  Console.ReadLine();
