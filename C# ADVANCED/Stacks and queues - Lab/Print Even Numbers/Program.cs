﻿Console.WriteLine(string.Join(", ", Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToArray()));
