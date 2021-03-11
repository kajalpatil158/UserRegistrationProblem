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

        string Email_Id = "^[a-z0-9A-Z]+([.#_+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})*$";
        string Mobile_Number = "^[91]{2}[ ][0-9]{10,10}$";
        string PassWord = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8,20}$";

            //"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*])(?=\\s+$).{8,20}$";
        public bool Validate(string first_name, string last_name,string email, string email1, string email2, string email3, string email4,
               /* ,    */
               string email5, string email6, string email7, string email8, string mobile_number,string password )
        {
            return Regex.IsMatch(first_name, First_Name) && Regex.IsMatch(last_name, Last_Name)&& 
                Regex.IsMatch(email,Email_Id)&&
                Regex.IsMatch(email1, Email_Id) &&
                Regex.IsMatch(email2, Email_Id) &&
                Regex.IsMatch(email3, Email_Id) &&
                Regex.IsMatch(email4, Email_Id) &&
                Regex.IsMatch(email5, Email_Id) &&
                Regex.IsMatch(email6, Email_Id) &&
                Regex.IsMatch(email7, Email_Id) &&
                Regex.IsMatch(email8, Email_Id) && 
                Regex.IsMatch(mobile_number,Mobile_Number)
                && Regex.IsMatch(password, PassWord);
        }
    }
} 