var stack = new Stack<int>();
var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < tokens[0]; i++)
{
    stack.Push(numbers[i]);
}
for (int i = 0; i < tokens[1]; i++)
{
    stack.Pop();
}
if (stack.Count() == 0) 
{
    Console.WriteLine(0);
}
else if (stack.Contains(tokens[2]))
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}