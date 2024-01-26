namespace NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());

                if (newNumber > maxNumber)
                {
                    maxNumber = newNumber;
                }
                if (newNumber < minNumber)
                {
                    minNumber = newNumber;
                }
            }
            Console.WriteLine("Max number: " + maxNumber);
            Console.WriteLine("Min number: " + minNumber);
        }
    }
}
