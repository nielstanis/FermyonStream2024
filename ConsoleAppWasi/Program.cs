using System;
using System.Runtime.InteropServices;

Console.WriteLine($"Hello Fermyon from {RuntimeInformation.OSArchitecture}!");

var file = System.IO.File.ReadAllText("/etc/hosts");
Console.WriteLine(file);