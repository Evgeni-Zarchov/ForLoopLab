namespace LeftandRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                leftSum = leftSum + newNumber;
            }
            int rightSum = 0;

            for (int i = 1;i <= n; i++)
            {
                int newSum = int.Parse(Console.ReadLine());
                rightSum = rightSum + newSum;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}
