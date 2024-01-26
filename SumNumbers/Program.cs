namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int nextNum = int.Parse(Console.ReadLine());
                sum += nextNum;
            }
            Console.WriteLine(sum);
        }
    }
}
