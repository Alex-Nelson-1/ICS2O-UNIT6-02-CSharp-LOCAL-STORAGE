// Created by: Alex Nelson
// Created on: Oct 2022
//
// This program calculates area of a triangle
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Input
        int length;
        int width;
        int area;
        Console.WriteLine("This program calculates the area of a triangle");
        Console.WriteLine("");
        Console.WriteLine("Enter length in cm: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter width in cm: ");
        width = Convert.ToInt32(Console.ReadLine());
        area = length * width / 2;
        //Output
        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm²");
        Console.WriteLine("\nDone");
    }
}
