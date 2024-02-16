namespace SredenElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedi chisla: ");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int middle = numbers.Length / 2;
           
            Console.WriteLine(numbers[middle]);
            
        }
    }
}
