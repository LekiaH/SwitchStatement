using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string subject = "Math";
            Console.WriteLine("Choose a subject. Math, English, Geology, Art or Typing.");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "Math":
                    Console.WriteLine("You're in the right class!");
                    break;
                case "English":
                    Console.WriteLine("Math is better than English");
                    break;
                case "Geology":
                    Console.WriteLine("The Earth is really old"!);
                    break;
                case "Art":
                    Console.WriteLine("Beauty is in the eye of the beholder");
                    break;
                case "Typing":
                    Console.WriteLine("How fast can you type?");

                    break;

                default:
                    Console.WriteLine("We teach coding");
                    break;
            }
        }
    }
}
