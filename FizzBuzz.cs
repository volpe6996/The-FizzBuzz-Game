using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_FizzBuzz_Game
{
    public class FizzBuzz
    {
        private int _inputNumber;
        public string StartGame()
        {
            Console.Write("Witaj w grze FizzBuzz! Podaj jedną liczbę: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out _inputNumber))
                {
                    Console.WriteLine("To nie jest liczba całkowita! Spróbuj ponownie!");
                    continue;
                }
                else
                {
                    Console.WriteLine(CheckInput(_inputNumber));
                    break;
                }
            }
            return "";
        }

        private string CheckInput(int input)
        {
            if(!(input % 3 == 0) && !(input % 5 == 0))
            {
                return input.ToString();
            }
            else if(input % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if(input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input % 5 == 0)
            {
                return "Buzz";
            }
            return "";
        }
    }
}
