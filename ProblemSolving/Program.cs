// See https://aka.ms/new-console-template for more information

using ProblemSolving;

var problem = new GroupAnagramsProblem();
var result = problem.GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });
foreach (var list in result)
{
    Console.WriteLine("Group 1");
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}