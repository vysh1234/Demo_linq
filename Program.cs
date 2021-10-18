using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Demo_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq implementation");

           // int[] scores = new int[] { 40, 33, 77, 54, 22 };

            string[] fruits = new string[] { "banana", "apple", "Pineapple", "Mango", "watermelon" };

            //IEnumerable<int> ScoreQuery =
              //  from score in scores
                //where score is > 30
                //select score;
            IEnumerable<string> FruitQuery =
                from fruit in fruits
                where fruit is "apple" or "banana"
                select fruit;

            foreach(var item in FruitQuery)
            {
                Console.WriteLine(item+" \n");
            }
        }
    }
}
