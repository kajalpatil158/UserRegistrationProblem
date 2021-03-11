using System;
using UserRegistrationProblem;

namespace UserRagistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationForms registration = new RegistrationForms();
            Console.WriteLine(registration.Validate("Kajal","Patil","kajal.patil.pune@gmail.com.in","91 8600208238","ABCDZXCV"));
            //Console.WriteLine("Mobile Number Is=", registration.Validate("91 8600208238"));
            Console.ReadLine();

        }

    }
}
