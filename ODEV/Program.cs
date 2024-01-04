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


            int level = Convert.ToInt32(Console.ReadLine());

            if (level == 1)
            {
                Console.WriteLine("You need to guess 3 numbers. And you have 3 rights");
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
                        if (right == 0)
                        {
                            Console.WriteLine("You Lost!");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }


            }

            else if (level == 2)
            {
                Console.WriteLine("You need to guess 3 numbers. And you have 3 rights");
                Random rnd = new Random();
                int number = rnd.Next(100);
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
                        if (right == 0)
                        {
                            Console.WriteLine("You Lost!");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            else if (level == 3)
            {
                Console.WriteLine("You need to guess 3 numbers. And you have 3 rights");
                Random rnd = new Random();
                int number = rnd.Next(1000);
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
                        if (right == 0)
                        {
                            Console.WriteLine("You Lost!");
                        }
                        else
                        {
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