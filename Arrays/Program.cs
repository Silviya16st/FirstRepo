namespace Arrays_InputOtput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Deklariram masiv ot 13 elementa
            double[] grades = new double[13]; //{ 1, 2, 3, 4};
            string[] names = new string[13] { "Lubo", "Milen", "Mihail",
                "Radoslav", "Svetlomir", "Siana", "Silviya", "Stanislav", 
                "Tedo", "Hristian", "Hristomir", "Cvetelina", "Cvetina"};
            
            //vavejdat se elementi ot klaviatyrata - cikal
            for (int index = 0; index < grades.Length; index++)
            {
                Console.WriteLine($"Ocenkata na {names[index]}");
                grades[index] = double.Parse(Console.ReadLine());
            }
            //obrabotka
            grades[11] = 6;
            names[11]="Cvetelina";
            grades[11] = Math.Ceiling(5.24);
            
            //Otpechatvane na rezyltatite
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine($"{j+14}");
            }
        }
    }
}
