namespace CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I have to write a program to show the words 
            // Bcs in programming we work with index and our first word is on index 0 
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
    }
}
