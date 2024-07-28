using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new(1, "C#");
            sub1.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start Exam ( y | n ) : ");
            char choice = char.Parse(Console.ReadLine());
            if (choice == 'y' || choice == 'Y')
            {
                Console.Clear();
                Stopwatch sw = new();
                sw.Start();
                sub1.SubjectExam.ShowExam();
                Console.WriteLine($"\nThe Elapsed Time = {sw.Elapsed}");
            }
            else
                Console.WriteLine("Thank You");
        }
    }
}
