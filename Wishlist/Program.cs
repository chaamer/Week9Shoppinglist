using System;
using System.Collections.Generic;

namespace Wishlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            myWishList.Add("coffee machine");
            myWishList.Add("socks");
            myWishList.Add("chocolate");

            Console.WriteLine(myWishList.Count);

            Console.WriteLine(myWishList[0]);
            Console.WriteLine(myWishList[1]);
            Console.WriteLine(myWishList[2]);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }


        }
    }
}
