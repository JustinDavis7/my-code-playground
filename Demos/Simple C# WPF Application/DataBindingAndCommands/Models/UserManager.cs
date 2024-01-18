﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingAndCommands.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DataBaseUser = new ObservableCollection<User>()
        {
            new User() { Email = "quam@aol.couk", Name = "Erich Fry" }, new User { Email = "in@yahoo.com", Name = "Virginia Salas" }, new User { Email = "luctus@google.com", Name = "Alvin Velasquez" }, new User { Email = "etiam.bibendum@hotmail.edu", Name = "Zia Hutchinson" }, new User { Email = "augue.porttitor@protonmail.org", Name = "Justin Burch" }
        };


    }

}
