namespace Part_6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to go to the prompter.");
            Console.ReadLine();
            Prompter();
        }

        public static void Prompter()
        {
            int minNum;
            int maxNum;
            Console.WriteLine("Please enter a number with a minimum value and maximum value.");
            Console.WriteLine("Please enter a minimum value:");
            minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum value:");
            maxNum = Convert.ToInt32(Console.ReadLine());
        }
    }
}