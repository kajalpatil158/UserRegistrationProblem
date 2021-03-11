using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class RegistrationForm
    {
        string First_Name = "^[A-Za-z]";
        string Last_Name = "^[A-Za-z]";
        public bool Validate(string first_name, string last_name)
        {
            return Regex.IsMatch(first_name, First_Name) && Regex.IsMatch(last_name, Last_Name);
        }
    }
} 