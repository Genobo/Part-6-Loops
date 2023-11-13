namespace Part_6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enter;
            Console.WriteLine("Enter 1 to go to the prompter, 2 for PercentPassing or 3 for OddSum.");
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
                if (amount >= 7)
                {
                    done = true;
                    Console.WriteLine($"The amount of scores higher than 70% are {amount}");
                }
            }
        }

        public static void OddSum()
        {
            Console.WriteLine("Please enter an odd number");
        }
    }
}