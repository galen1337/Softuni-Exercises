using Stack;
using System.Globalization;


CustomStack stack = new CustomStack();
Console.WriteLine(stack.IsEmpty());
List<string> strings = new List<string> { "abc", "def", "ghi","jkl","mno","pqr","stu","vwx","yz" };
stack.AddRange(strings);
Console.WriteLine(stack.IsEmpty());