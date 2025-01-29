using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Theme34Lesson6
{
    public class DbStudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbStudentContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=192.168.10.93;database=VideoGame;user=video-game-admin;password=000000",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
