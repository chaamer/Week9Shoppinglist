﻿using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\Desktop\Programmeerimine\samples";
            Console.WriteLine("Enter folder name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            //console.writeline("Enter folder name:");
            //string newDirectory = Console.ReadLine();
            string fileName = Console.ReadLine();

            //Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            //File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Folder {newDirectory} and file allready exists at {rootDirectory}");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
