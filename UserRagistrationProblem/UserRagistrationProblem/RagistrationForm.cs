﻿using System;
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
        public bool Validate(string first_name, string last_name,string email )
        {
            return Regex.IsMatch(first_name, First_Name) && Regex.IsMatch(last_name, Last_Name)&& Regex.IsMatch(email,Email_Id);
        }
    }
} 