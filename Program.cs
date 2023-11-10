namespace Part_6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enter;
            Console.WriteLine("Enter 1 to go to the prompter or 2 for PercentPassing.");
            enter = Convert.ToInt32(Console.ReadLine());
            if (enter == 1)
            {
                Prompter();
            }
            else if (enter == 2)
            {
                PercentPassing();
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
        }

        public static void PercentPassing()
        {
            Console.WriteLine("Welcome to PercentPassing");
        }
    }
}