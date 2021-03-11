using System;
using UserRegistrationProblem;

namespace UserRagistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationForms registration = new RegistrationForms();
            Console.WriteLine(registration.Validate("Kajal","Patil","kajal.patil.pune@gmail.com.in"));
            Console.ReadLine();

        }
    }
}
