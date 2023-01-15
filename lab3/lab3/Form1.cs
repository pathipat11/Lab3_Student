using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        //array <-> List
        List<Student> _student = new List<Student>();
        double maxigrade = 0;
        double minigrade = int.MaxValue;
        int People = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonALL_Click(object sender, EventArgs e)
        {
            ////get value from object attribute
            String name = this.textBoxName.Text;
            String id = this.textBoxId.Text;
            String year = this.textBoxBirth.Text;
            String height = this.textBoxHeight.Text;
            String grade = this.textBoxGrade.Text;
            String faculty = this.textBoxFaclty.Text;

            ////convert string to int
            int iYear = Int32.Parse(year);
            int iheight = Int32.Parse(height);
            double igrade = Double.Parse(grade);

            ////create obj from student
            Student newStudent = new Student(name, id, iYear, iheight, igrade, faculty);

            ////add new student it list
            this._student.Add(newStudent);

            ////create textbox
            this.textBoxName.Text = "";
            this.textBoxId.Text = "";
            this.textBoxBirth.Text = "";
            this.textBoxHeight.Text = "";
            this.textBoxGrade.Text = "";
            this.textBoxFaclty.Text = "";
            this.textBoxMax.Text = "";
            this.textBoxMin.Text = "";
            this.textBoxPeople.Text = "";

            ////add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._student;
            this.dataGridView1.DataSource = source;


            ////show max min
            if (igrade > maxigrade)
            {
                maxigrade = igrade;
            }
            if (igrade < minigrade)
            {
                minigrade = igrade;
            }
            
            this.textBoxMax.Text = this.textBoxMax.Text + maxigrade;
            this.textBoxMin.Text = this.textBoxMin.Text + minigrade;

            //// People
            People = People + 1;
            
            this.textBoxPeople.Text = this.textBoxPeople.Text + People;
        }
        // delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.textBoxName.Text = "";
            this.textBoxId.Text = "";
            this.textBoxBirth.Text = "";
            this.textBoxHeight.Text = "";
            this.textBoxGrade.Text = "";
            this.textBoxFaclty.Text = "";
        }

    }
}