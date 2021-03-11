using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class RegistrationForms
    {
        string First_Name = "^[A-Za-z]";
        string Last_Name = "^[A-Za-z]";

        string Email_Id = "^[a-z0-9A-Z]+([.#_+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})*$";
        string Mobile_Number = "^[91]{2}[ ][0-9]{10,10}$";
        string PassWord = "^[A-Z]{8}";
        public bool Validate(string first_name, string last_name,string email,string mobile_number,string password )
        {
            return Regex.IsMatch(first_name, First_Name) && Regex.IsMatch(last_name, Last_Name)&& 
                Regex.IsMatch(email,Email_Id)&& Regex.IsMatch(mobile_number,Mobile_Number)
                && Regex.IsMatch(password, PassWord);
        }
    }
} 