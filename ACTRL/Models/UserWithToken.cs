﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTRL.Models
{
    public class UserWithToken
    {
     /*
        public User(int id, string email, string password, string firstName, string lastName, DateTime dtIn)
        {
            Id = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            DtIn = dtIn;
        }
     */
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DtIn { get; set; }
        public bool IsAdmin { get; set; }

    }

}