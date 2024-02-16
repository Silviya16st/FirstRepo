namespace AgregatArrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dai broi na elementite: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            //inpu the elements
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                Console.Write($"num[{1}] = ");
                numbers[1] = int.Parse(Console.ReadLine());
            }

            //2
            long sum = 0l;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
                
            }
            Console.WriteLine($"Sum= {sum}");

            int min = int.MinValue; 
            int minPos = 0;
            for(int i = 0 ; i < numbers.Length ; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minPos = i;
                }
            }

            //print ALL elements
            for (int i = 0;i <= numbers.Length-1; i++)
            {
                Console.WriteLine($"num[{1}] = {numbers[i]}");
            }
        }
    }
}
