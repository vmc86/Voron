using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorony
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = true;
            do
            {
                Console.WriteLine("Input an integer number: ");
                int number;
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    // 0-9, ..., 20-29, 30-39
                    // 11-14
                    if ((number % 100) > 10 && (number % 100) < 20)
                        Console.WriteLine("Voron");
                    else
                    {
                        switch (number % 10)
                        {
                            case 0:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                                Console.WriteLine("Voron");
                                break;
                            case 1:
                                Console.WriteLine("Vorona");
                                break;
                            case 2:
                            case 3:
                            case 4:
                                Console.WriteLine("Vorony");
                                break;
                            default:
                                break;
                        }
                    }
                    do
                    {
                        Console.WriteLine("Continue? (y/n): ");
                        var isContinue = Console.ReadLine();
                        if (isContinue.ToLower() == "y")
                        {
                            break;
                        }
                        else if (isContinue.ToLower() == "n")
                        {
                            gameOver = false;
                        }
                    } while (gameOver);
                }
                else
                    Console.WriteLine("Необходимо ввести число!!!");
            } while (gameOver);
            Console.WriteLine("The End");
        }
    }
}
