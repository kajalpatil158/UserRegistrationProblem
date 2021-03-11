using System;
using UserRegistrationProblem;

namespace UserRagistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationForm registration = new RegistrationForm();
            Console.WriteLine(registration.Validate("Kajal"));
            Console.ReadLine();

        }
    }
}
