using System.Collections.ObjectModel;

namespace Theme34Lesson6
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            UpdateForm();
        }
        private async void UpdateForm()
        {
            Crud crud = new Crud();
            List<Student> result = await Task.Run(() =>crud.ReadAll());
            students = result;
            dataGridView1.DataSource = students;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            FormAdEditStudent formAdEditStudent = new FormAdEditStudent(student);
            if (formAdEditStudent.ShowDialog() == DialogResult.OK)
            {
                Crud crud = new Crud();
                student.FirstName = formAdEditStudent.textBoxFirstName.Text;
                student.LastName = formAdEditStudent.textBoxLastName.Text;
                student.Age = (int)formAdEditStudent.numericUpDown‘ÔÛ.Value;
                crud.Add(student);
                UpdateForm();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            Crud crud = new Crud();
            Student student = students[index];
            FormAdEditStudent formAdEditStudent = new FormAdEditStudent(student);
            if (formAdEditStudent.ShowDialog() == DialogResult.OK)
            {
                student.FirstName = formAdEditStudent.textBoxFirstName.Text;
                student.LastName = formAdEditStudent.textBoxLastName.Text;
                student.Age = (int)formAdEditStudent.numericUpDown‘ÔÛ.Value;
                crud.Update(student);
                UpdateForm();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            Crud crud = new Crud();
            Student student = students[index];
            crud.Delete(student.Id);
            UpdateForm();
        }
    }
}
