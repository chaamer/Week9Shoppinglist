using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\Desktop\Programmeerimine\samples\shoppinglist";
            string fileName = @"\\myshoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");

            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Add things to your shopping list? Todo that press Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter what you need from shop:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }

                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");

                }
            }

            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Your shoppinglist: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
        }
    }
}
