using System;

namespace _10011845_task2_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
         //Clear
         Console.Clear();
         //Var creation
        var num = "";
        var input = 0;
        var isNum = int.TryParse(num, out input);
        for (var count = 0; count <=9; count++)
        {
         //Ask for user input
        Console.WriteLine("Please pick a number");
        num = Console.ReadLine();
         //Print there input
        Console.WriteLine($"You picked number {num}");
        Console.WriteLine(Environment.NewLine);
        



         //Make sum
        }
         //Print Results
         Console.WriteLine("");
         //END
         Console.WriteLine("Program ending, Thank you");
        Console.ReadKey();
        }
    }
}
