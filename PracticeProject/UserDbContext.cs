﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class UserDbContext:DbContext
    {
        private StreamWriter infoLog = new StreamWriter("infoLog.log",true);
        private StreamWriter warningLog = new StreamWriter("warningLog.log", true);
        private StreamWriter criticalLog = new StreamWriter("criticalLog.log", true);
        public UserDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Person> People { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(infoLog.WriteLine, LogLevel.Information);
            optionsBuilder.LogTo(warningLog.WriteLine, LogLevel.Warning);
            optionsBuilder.LogTo(criticalLog.WriteLine, LogLevel.Critical);
        }

        public override void Dispose()
        {
            base.Dispose();
            infoLog.Dispose();
            warningLog.Dispose();
            criticalLog.Dispose();
        }
    }
}
