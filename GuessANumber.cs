using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();


            for (int level = 1; level < 4; level++)
            {
                int computerNumber = randomNumber.Next(1, 101);
                int tries = 0;

                switch (level)
                {
                    case 1:
                        tries = 50;
                        break;
                    case 2:
                        tries = 25;
                        break;
                    case 3:
                        tries = 5;
                        break;
                }

                Console.WriteLine($"LEVEL {level}");

                while (tries > 0)
                {
                    Console.WriteLine("Guess a numer (1-100): ");
                    Console.WriteLine($"Tries left: {tries}");

                    string playerInput = Console.ReadLine();
                    bool isValid = int.TryParse(playerInput, out int playerNumber);

                    if (isValid)
                    {
                        if (playerNumber == computerNumber)
                        {
                            Console.WriteLine("You guessed it!");
                            Console.WriteLine();
                            break;
                        }
                        else if (playerNumber > computerNumber)
                        {
                            Console.WriteLine("Too Hight");
                            tries--;
                        }
                        else
                        {
                            Console.WriteLine("Too Low");
                            tries--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }

                if (tries == 0)
                {
                    Console.WriteLine("Game Over");
                    return;
                }
            }

            Console.WriteLine("You Win!");
        }
    }
}
