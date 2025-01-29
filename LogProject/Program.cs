using LogProject;

using (DataBaseContext db=new DataBaseContext())
{
    List<Person> list = new List<Person>() {
        new Person("Валерий", "Valery@mail.ru", "000000"),
        new Person("Елена", "Elena@gmail.com", "123456"),
        new Person("Иван", "Ivan@example.com", "qwerty"),
        new Person("Анна", "Anna@mail.ru", "password123")
    };
    db.Persons.AddRange(list);
    db.SaveChanges();
}
Console.WriteLine("Успешно");
