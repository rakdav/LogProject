using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme34Lesson6
{
    public class Crud : ICrudStudent
    {
        private DbStudentContext db;
        public Crud()=>db=new DbStudentContext();
        
        public async void Add(Student student)
        {
            await db.Students.AddAsync(student);
            await db.SaveChangesAsync();
        }
        public async void Delete(int id)
        {
            Student? student = await db.Students.FirstOrDefaultAsync(s => s.Id == id);
            db.Students.Remove(student!);
            await  db.SaveChangesAsync();
        }

        public async Task<List<Student>> Find(string param)
        {
            return await db.Students.Where(p => p.FirstName!.StartsWith(param)
            || p.LastName!.StartsWith(param)).ToListAsync();
        }

        public async Task<Student?> Read(int id)
        {
            return await db.Students.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Student>> ReadAll()
        {
            return await db.Students.ToListAsync();
        }

        public async void Update(Student _student)
        {
            Student? student= await db.Students.FirstOrDefaultAsync(s => s.Id == _student.Id);
            if (student != null)
            {
                student!.FirstName = _student.FirstName;
                student.LastName=_student.LastName;
                student.Age = _student.Age;
                db.Students.Update(student);
                await db.SaveChangesAsync();
            }
        }
    }
}
