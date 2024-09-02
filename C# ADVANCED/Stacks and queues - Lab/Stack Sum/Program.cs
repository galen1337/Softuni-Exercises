var nums = new Stack<int>();
string input;
var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
foreach (var number in numbers)
{
    nums.Push(number);
}
while ((input = Console.ReadLine()).ToLower() != "end")
{
    var tokens = input.Split().ToArray();
    switch (tokens[0])
    {
        case "add":
            for (int i = 1; i < tokens.Length; i++)
                nums.Push(int.Parse(tokens[i]));
            break;

        case "remove":
            for (int i = 0; i < int.Parse(tokens[1]); i++)
                nums.Pop();
            break;

    }
}
Console.WriteLine("Sum: " + nums.Sum());
