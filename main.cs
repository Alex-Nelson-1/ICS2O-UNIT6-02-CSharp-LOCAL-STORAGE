// Created by: Alex Nelson
// Created on: Jan 2022
//
// This program stores a local variable
using System;
using System.Threading.Tasks;
using System.IO;

class Program
{
    public static async Task Main()
    {
        var counter = 1;
        Console.WriteLine("Do you want to end this program, y or n?");
        string text = Console.ReadLine();
        if (text == "n")
        {
            while (text == "n")
            {
                Console.WriteLine("Do you want to end this program, y or n?");
                text = Console.ReadLine();
                counter = counter + 1;
                await File.WriteAllTextAsync("WriteText.txt", "you have said no " + counter + " times.");
                var said = await File.ReadAllTextAsync(@"WriteText.txt");
                Console.WriteLine(said);
            }
        }
        else if (text == "y")
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Please restart and choose y for yes, and n for no.");
        }
        Console.WriteLine("\nDone");
    }
}
