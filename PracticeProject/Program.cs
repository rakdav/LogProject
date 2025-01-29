
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PracticeProject;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("connection.json");
var config = builder.Build();
var connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<UserDbContext>();
var version = new MySqlServerVersion(new Version(8, 0, 25));
var options = optionsBuilder.UseMySql(connectionString, version).Options;
using (UserDbContext db = new UserDbContext(options))
{
    Person person = new Person() { Email = "fast@mail.ru", Name = "Fast", Password = "Qwerty" };
    db.People.Add(person);
    db.SaveChanges();
}






