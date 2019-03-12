using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            var squareList = new List<int>();

            for (var i=0; i<20; i++)
            {
                int digit = rand.Next(1, 51);
                squareList.Add(digit*digit);
            }

            squareList.RemoveAll(i => i % 2 != 0);

        }
    }
}
