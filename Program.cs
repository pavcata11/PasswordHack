using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordHack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> lockNumbers = new List<int>();
            List<int> invalidSet = new List<int>();
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            List<int> trueCombination = new List<int>();
            Console.WriteLine("Input all the numbers");
            while (lockNumbers.Count <= 14)
            {
                int numbers = int.Parse(Console.ReadLine());
                lockNumbers.Add(numbers);
                if (lockNumbers.Count >= 10 && lockNumbers.Count < 13)
                {
                    invalidSet.Add(numbers);
                }
            }

            List<int> invalidNumbersRemoved = lockNumbers.Except(invalidSet).ToList();
            firstNumber = invalidNumbersRemoved.Last();
            thirdNumber = invalidNumbersRemoved.IndexOf(1);
            invalidNumbersRemoved.RemoveAll(item => item == firstNumber);
            invalidNumbersRemoved.RemoveAll(item => item == thirdNumber);
            secondNumber = invalidNumbersRemoved.Last();
            trueCombination.Add(firstNumber);
            trueCombination.Add(secondNumber);
            trueCombination.Add(thirdNumber);
            Console.WriteLine("Password Is:");
            foreach (var numbers in trueCombination)
            {
                Console.Write(numbers);
            }
            // Вход
            /*
            6
            8
            2
            6
            1
            4
            2
            0
            6
            7
            3
            8
            7
            8
            0
            */
            //изход 042
        }
    
    }
}
