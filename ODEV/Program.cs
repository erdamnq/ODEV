namespace ODEV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find the number");
            Console.WriteLine("////////////////////////");
            Console.WriteLine("Select the difficulty level");
            Console.WriteLine("1-Easy");
            Console.WriteLine("2-Medium");
            Console.WriteLine("3-Hard");
            int right = 3;
            int point = 100;
            int level = Convert.ToInt32(Console.ReadLine());
            if (level == 1)
            {
                Console.WriteLine("You need to guess 1 numbers. And you have 3 rights. (In 1-4)");
                Random rnd = new Random();
                int number = rnd.Next(5);
                int unumber;
                for (int i = 0; i < right; i--)
                {
                    Console.WriteLine("Guess the number:");
                    unumber = int.Parse(Console.ReadLine());
                    if (unumber == number)
                    {
                        Console.WriteLine("You WON!");
                        break;
                    }
                    else if (unumber != number)
                    {
                        Console.WriteLine("Try Again!");
                        right--;
                        Console.WriteLine(point-5);
                        if (right == 0)
                        {
                            Console.WriteLine("You Lost!");
                            break;
                        }
                        else
                        {
                            point = point - 5;
                            continue;
                        }
                    }
                }
            }

            else if (level == 2)
            {
                Console.WriteLine("You need to guess 1 numbers. And you have 3 rights.(In 1-10)");
                Random rnd = new Random();
                int number = rnd.Next(10);
                int unumber;
                for (int i = 0; i < right; i--)
                {
                    Console.WriteLine("Guess the number:");
                    unumber = int.Parse(Console.ReadLine());

                    if (unumber == number)
                    {
                        Console.WriteLine("You WON!");
                        break;
                    }
                    else if (unumber != number)
                    {
                        Console.WriteLine("Try Again!");
                        right--;
                        Console.WriteLine(point - 10);
                        if (right == 0)
                        {
                            Console.WriteLine("You Lost!");
                        }
                        else
                        {
                            point = point - ;
                            continue;
                        }
                    }
                }
            }

            else if (level == 3)
            {
                Console.WriteLine("You need to guess 1 numbers. And you have 3 rights.(In 0-25)");
                Random rnd = new Random();
                int number = rnd.Next(25);
                int unumber;
                for (int i = 0; i < right; i--)
                {
                    Console.WriteLine("Guess the number:");
                    unumber = int.Parse(Console.ReadLine());

                    if (unumber == number)
                    {
                        Console.WriteLine("You WON!");
                        break;
                    }
                    else if (unumber != number)
                    {
                        Console.WriteLine("Try Again!");
                        right--;
                        Console.WriteLine(point - 20);

                        if (right == 0)
                        {
                            Console.WriteLine("You Lost!");
                            break;
                        }
                        else
                        {
                            point = point - 20;
                            continue;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter Valid Number");
            }
        }
    }
}
