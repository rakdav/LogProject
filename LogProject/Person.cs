﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogProject
{
    public class Person
    {
        [Key]
        [Column("Person_Id")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Person(string? name, string? email, string? password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
