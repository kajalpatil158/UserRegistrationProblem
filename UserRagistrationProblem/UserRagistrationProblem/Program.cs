using System;
using UserRegistrationProblem;

namespace UserRagistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationForms registration = new RegistrationForms();
            Console.WriteLine(registration.Validate("Kajal","Patil",
                                                       "abc-100@gmail.com.in",
                                                      "abc@yahoo.com",
                                                      "abc.100@gmail.com",
                                                      "abc111@abc.com",
                                                      "abc-100@abc.net",
                                                      "abc-100@abc.in.in",
                                                      "ab@1.com",
                                                      "abc+100@gmail.com", 
                                                      "abc@gamail.com.in",
                                                      "91 8600208238",
                                                      "KAJAL@Patil123"));
            Console.ReadLine();
            
        }

    }
}
