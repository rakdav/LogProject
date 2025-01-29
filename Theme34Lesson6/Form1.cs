namespace Theme34Lesson6
{
    public partial class Form1 : Form
    {
        private Crud crud;
        public Form1()
        {
            InitializeComponent();
            crud = new Crud();
            UpdateForm();
        }
        private void UpdateForm()
        {
            List<Student> list= Task.Run(() => crud.ReadAll()).Result;
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdEditStudent formAdEditStudent = new FormAdEditStudent();
            if(formAdEditStudent.ShowDialog() == DialogResult.OK)
            {
                Student student = new Student();
                student.FirstName=formAdEditStudent.textBoxFirstName.Text;
                student.LastName = formAdEditStudent.textBoxLastName.Text;
                student.Age = (int)formAdEditStudent.numericUpDown‘ÔÛ.Value;
                crud.Add(student);
                UpdateForm();
            }
        }
    }
}
