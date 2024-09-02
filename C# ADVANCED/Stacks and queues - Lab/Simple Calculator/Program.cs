using System.Reflection.Metadata;

var stack = new Stack<int>();
var input = Console.ReadLine().Split().ToArray();
stack.Push(int.Parse(input[0]));
for (int i = 2; i < input.Length; i += 2)
{
    stack.Push(input[i - 1] == "+" ? int.Parse(input[i]) : int.Parse(input[i]) * -1);
}
Console.WriteLine(stack.Sum());