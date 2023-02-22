using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var subject = Console.ReadLine();
            
            // Switch to determine an output
            switch(subject)
            {
                case ("math"):
                    Console.WriteLine("The foundation of all great things. Well done on choosing math.");
                    break;
                case ("english"):
                    Console.WriteLine("I guess you can read about Math in your English class.");
                    break;
                case ("history"):
                    Console.WriteLine("All of the greatest moments in history revolve around mathematical discoveries.");
                    break;
                case ("lunch"):
                    Console.WriteLine("Lunch is the only acceptable break from math class.");
                    break;
                case ("science"):
                    Console.WriteLine("Science is just applied math. But still very exciting");
                    break;
                default:
                    Console.WriteLine("Might I suggest math next time?");
                    break;
            }
        }
    }
}