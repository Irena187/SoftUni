using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string key = Console.ReadLine();

            string input;
            while((input = Console.ReadLine()) != "Generate")
            {
                string[] instructions = input.Split(">>>");
                string command = instructions[0];

                if(command == "Contains")
                {
                    string substring = instructions[1];

                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if(command == "Flip")
                {
                    string size = instructions[1];
                    int startIndex = int.Parse(instructions[2]);
                    int endIndex = int.Parse(instructions[3]);
                    string substring = key.Substring(startIndex, endIndex - startIndex);

                    if (size == "Upper")
                    {
                        substring = substring.ToUpper();
                        key = key.Remove(startIndex, endIndex - startIndex);
                        key = key.Insert(startIndex, substring); //insert
                        Console.WriteLine(key);
                    }
                    else if (size == "Lower")
                    {
                        substring = substring.ToLower();
                        key = key.Remove(startIndex, endIndex - startIndex);
                        key = key.Insert(startIndex, substring); //insert
                        Console.WriteLine(key);
                    }
                }
                else //Slice
                {
                    int startIndex = int.Parse(instructions[1]);
                    int endIndex = int.Parse(instructions[2]);

                    key = key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                } 
            }
            Console.WriteLine($"Your activation key is: {key}");

        }

    }
    
}    
