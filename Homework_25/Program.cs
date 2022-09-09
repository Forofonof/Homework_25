using System;

internal class Program
{
    static void Main(string[] args)
    {
        string text = "Я точно стану Junior Unity Developers.";
        string[] newLine = text.Split(' ');

        foreach (var word in newLine)
        {
            Console.WriteLine($"{word}");
        }
    }
}