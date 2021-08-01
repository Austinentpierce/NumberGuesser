using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Hello I am the Number Guesser and I bet I can guess your number");
                int lowestNumber = 1;
                int highestNumber = 1024;
                int DifferenceOfRange = highestNumber - lowestNumber;
                int Midpoint = DifferenceOfRange / 2;
                int middleNumberValue = lowestNumber + Midpoint;
                bool Number = true;
                while (lowestNumber <= highestNumber && Number)
                {
                    DifferenceOfRange = highestNumber - lowestNumber;
                    Midpoint = DifferenceOfRange / 2;
                    middleNumberValue = lowestNumber + Midpoint;
                    Console.WriteLine("Is your number: {0}?", middleNumberValue);
                    Console.WriteLine(" 1: That is correct it is my number \n 2: Nope my number is actually greater than that \n 3: Nope my number is actually lower than that ");
                    int numberGuessed = int.Parse(Console.ReadLine());
                    if (numberGuessed == 1)
                    {
                        Console.WriteLine("Looks like I won! Better luck next time!");
                        Number = false;
                    }
                    if (lowestNumber < highestNumber && numberGuessed == 2)
                    {
                        lowestNumber = middleNumberValue + 1;
                    }
                    else if (lowestNumber < highestNumber && numberGuessed == 3)
                    {
                        highestNumber = middleNumberValue - 1;
                    }
                }
                {
                }
            }
        }
    }



}




