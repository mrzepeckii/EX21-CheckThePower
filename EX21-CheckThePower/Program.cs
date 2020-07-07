using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

namespace EX21_CheckThePower
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] squares = { 1, 4, 9, 16, 25 };
            Console.WriteLine(checkThePower( numbers, squares));
        }


        static bool checkThePower(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            var numberToPower = from number in numbers
                                select number * number;
            if (numberToPower.SequenceEqual(squares))
                return true;
            return false;
        }
    }
}
