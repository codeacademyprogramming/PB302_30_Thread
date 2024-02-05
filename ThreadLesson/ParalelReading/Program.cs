

using System.Diagnostics;

List<string> names = new List<string> { "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8", "name9", "name10", "name11", "name12", "name13", "name14", "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8", "name9", "name10", "name11", "name12", "name13", "name14" };


Stopwatch sw = Stopwatch.StartNew();
Parallel.ForEach(names, x =>
{
    Thread.Sleep(10);
    Console.WriteLine($"{x} - {Thread.CurrentThread.ManagedThreadId}");
});
Console.WriteLine("Paralel foreach: " + sw.Elapsed.TotalSeconds);

sw = Stopwatch.StartNew();
foreach (var item in names)
{
    Thread.Sleep(10);
    Console.WriteLine($"{item} - {Thread.CurrentThread.ManagedThreadId}");
}
Console.WriteLine("Regular foreach: "+sw.Elapsed.TotalSeconds);
