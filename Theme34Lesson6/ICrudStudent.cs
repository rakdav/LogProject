using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme34Lesson6
{
    public interface ICrudStudent
    {
        void Add(Student student);
        Task<List<Student>> ReadAll();
        Task<Student?> Read(int id);
        Task<List<Student>> Find(string param);
        void Delete(int id);
        void Update(Student student);
    }
}
