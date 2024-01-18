
using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the dice throwing simulator!");
        // get user input for the number of rolls
        Console.Write("How many dice rolls would you like to simulate:");

        int nRolls = int.Parse(Console.ReadLine());
        // create an instance of the DRoller class and simulate dice rolls
        DRoller dRoller = new DRoller();

        int[] results = dRoller.SimulateRolls(nRolls);

        // print the histogram
        PrintHistogram(results, nRolls);

        Console.ReadLine(); 

    }
    // class to print the histomgram of *'s
    static void PrintHistogram(int[] results, int nRolls)
    {
        Console.WriteLine("\nHistogram:");

        for (int i = 2; i <= 12; i++)
        {
            // calculate the percentage for each number and print the corresponding num of *'s
            int percentage = results[i] * 100 / nRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }
    }
}