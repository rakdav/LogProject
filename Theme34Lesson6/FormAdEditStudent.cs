using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theme34Lesson6
{
    public partial class FormAdEditStudent : Form
    {
        public FormAdEditStudent(Student student)
        {
            InitializeComponent();
            if(student.Id != 0 ) 
            {
                textBoxFirstName.Text = student.FirstName;
                textBoxLastName.Text = student.LastName;
                numericUpDownФпу.Value=student.Age;
            }
        }
    }
}
