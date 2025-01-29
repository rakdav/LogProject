using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogProject
{
    public class DataBaseContext:DbContext
    {
        private StreamWriter logWriter = new StreamWriter("LogFile.log", true);
        public DbSet<Person> Persons { get; set; } = null!;
        public DataBaseContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;" +
                "Username=postgres;Password=postgres");
            optionsBuilder.LogTo(logWriter.WriteLine,LogLevel.Trace);
        }
        public override void Dispose()
        {
            base.Dispose();
            logWriter.Dispose();
        }
    }
}
