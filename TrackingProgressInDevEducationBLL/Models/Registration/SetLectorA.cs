﻿using System;

namespace TrackingProgressInDevEducationBLL.Models.Registration
{
    public class SetLectorA : ADTOAnswer
    {
        public string Login { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public SetLectorA()
        {
        }

        public SetLectorA(string login, string fullName, string email, string password)
        {
            Login = login;
            FullName = fullName;
            Email = email;
            Password = password;
        }
        public override bool Equals(object obj)
        {
            return Equals((SetLectorA)obj);
        }

        private bool Equals(SetLectorA other)
        {
            return  FullName == other.FullName 
                    && Email == other.Email
                    && Password == other.Password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, Email, Password);
        }
    }
}