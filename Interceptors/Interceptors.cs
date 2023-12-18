using System;
using System.Runtime.CompilerServices;
var example = new Example();


example.Method("Test");
example.Method("Test");
example.Method("Test");




public class Example
{
    public void Method(string word)
    {
        Console.WriteLine($"This is: {word}");
    }
}

