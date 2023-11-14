namespace Part_6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enter;
            Console.WriteLine("Enter 1 to go to the Prompter, 2 for PercentPassing, 3 for OddSum or 4 for Random Number generator.");
            enter = Convert.ToInt32(Console.ReadLine());
            if (enter == 1)
            {
                Prompter();
            }
            else if (enter == 2)
            {
                PercentPassing();
            }
            else if (enter == 3)
            {
                OddSum();
            }
            else if (enter == 4)
            {
                RandomNumbers();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public static void Prompter()
        {
            int minNum;
            int maxNum;
            int range;
            Console.WriteLine("Please enter a number with a minimum value and maximum value.");
            Console.WriteLine("Please enter a minimum value:");
            minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum value:");
            maxNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter in a number within the range of the two values that you entered");
            range = Convert.ToInt32(Console.ReadLine());
            if (range > maxNum)
            {
                Console.WriteLine("That number is bigger than the maximum value");
            }
            else if (range < minNum)
            {
                Console.WriteLine("That number is smaller than the minimum value");
            }
            Console.WriteLine($"The range of the numbers are {minNum + range + maxNum}");
        }

        public static void PercentPassing()
        {
            int percent;
            int amount = 0;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Please enter a set of scores and I'll calculate the amount of scores above 70%");
                percent = Convert.ToInt32(Console.ReadLine());
                amount++;
                if (amount >= 3)
                {
                    done = true;
                    Console.WriteLine($"{amount} of scores entered were above 70%");
                }
            }
        }

        public static void OddSum()
        {
            int num;
            Console.WriteLine("Please enter a number and I'll sum the odd numbers from 1 to the number entered");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of the numbers are {1 + 3 + 5 + num}");
        }

        public static void RandomNumbers()
        {
            Random generator = new Random();
            int minNum;
            int maxNum;
            Console.WriteLine("Enter in a minimum and maximum value for me to generate 25 random numbers in the range");
            Console.WriteLine("Enter a minimum value:");
            minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum value:");
            maxNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 25; i++)
            {
                Console.Write(generator.Next(minNum, maxNum) + " ");
            }
        }
    }
}