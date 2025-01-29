using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme34Lesson6
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Имя")]
        public string? FirstName { get; set; }
        [DisplayName("Фамилия")]
        public string? LastName { get; set; }
        [Required]
        [DisplayName("Возраст")]
        public int Age { get; set; }
    }
}
