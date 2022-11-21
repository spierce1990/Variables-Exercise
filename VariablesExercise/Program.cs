using System.Globalization;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");
            /* Declare and initialize string
            int char bool double decimal*/


            Console.WriteLine(" May I know your name?");
            string? userName = Console.ReadLine();

            Console.WriteLine($"Hi there, {userName}");

            Console.WriteLine("May I know your gender? Type M or F");
           string? genderType = Console.ReadLine();
            Console.WriteLine($"Hi there {userName}, your gender is {genderType}");

            Console.WriteLine($"Hi {userName}, may I also know your age?");
        string? userAge = Console.ReadLine( );
            Convert.ToInt32(userAge);
            Console.WriteLine($"You are currently {userAge} of age");

            Console.WriteLine("May I know your height with decimals?");
            string? userHeight = Console.ReadLine();
            Convert.ToDecimal(userHeight);
            Console.WriteLine($"Your exact height is {userHeight}");

            Console.WriteLine("May I ask if the all statement provided are true?");
            string? userTrue = Console.ReadLine();
            Convert.ToBoolean(userTrue);

            Console.WriteLine($"It is confirmed that all statement is: {userTrue}");











        }
    }
}
