﻿
string path = @"C:\data";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

Console.WriteLine(lines.Length);