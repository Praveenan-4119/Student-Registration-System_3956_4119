using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Student_Registration_System_3956_4119
{
    
    public partial class StudentRegistration_Window : Window
    {
        public List<Student>? DatabaseStudents { get; private set; }
        public StudentRegistration_Window()
        {
            InitializeComponent();
        }
        public void Create()
        {

            using (Student_Data_Context context = new Student_Data_Context())
            {
                var SFname = FNameTextBox.Text;
                var SLname = LNameTextBox.Text;
                var SRNumber = RNumberTextBox.Text;
                var Gpa = gpatxt.Text;

                if (SFname != null && SLname != null && SRNumber != null && Gpa != null)
                {
                    context.Students.Add(new Student() { FirstName = SFname, LastName = SLname, RegNum = SRNumber, GPA = Gpa });
                    context.SaveChanges();
                }

            }
        }

        public void Read()
        {
            using (Student_Data_Context context = new Student_Data_Context())
            {
                DatabaseStudents = context.Students.ToList();
                ItemList.ItemsSource = DatabaseStudents;
            }

        }

        public void Update()
        {
            using (Student_Data_Context context = new Student_Data_Context())
            {

                Student selectedStudent = ItemList.SelectedItem as Student;

                var SFname = FNameTextBox.Text;
                var SLname = LNameTextBox.Text;
                var SRNumber = RNumberTextBox.Text;
                var Gpa = gpatxt.Text;

                if (selectedStudent != null)
                {

                    Student student = context.Students.Find(selectedStudent.Id);
                    student.FirstName = SFname;
                    student.LastName = SLname;
                    student.RegNum = SRNumber;
                    student.GPA = Gpa;

                    context.SaveChanges();
                }

                else
                {
                    MessageBox.Show("Please Select the student to Update", "Warning!");
                }

            }

        }

        public void Delete()
        {
            using (Student_Data_Context context = new Student_Data_Context())
            {

                Student selectedUser = ItemList.SelectedItem as Student;

                if (selectedUser != null)
                {
                    Student student = context.Students.Single(x => x.Id == selectedUser.Id);

                    context.Remove(student);
                    context.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Please Select the student to Delete", "Warning!");
                }

            }

        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            Read();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        
        private void GPA_Click(object sender, RoutedEventArgs e)
        {
            int m1, m2, m3;
            int u1, u2, u3;

            m1 = int.Parse(stxt6.Text);
            m2 = int.Parse(stxt5.Text);
            m3 = int.Parse(stxt4.Text);

            u1 = int.Parse(ctxt3.Text);
            u2 = int.Parse(ctxt2.Text);
            u3 = int.Parse(ctxt1.Text);

            double cgp = point(m1) * u1 + point(m2) * u2 + point(m3) * u3;
            int tu = u1 + u2 + u3;
            double ggpa = cgp / tu;
            

            Gtxt1.Text = Grade(m1);
            Gtxt2.Text = Grade(m3);
            Gtxt3.Text = Grade(m2);

            
            Ptxt1.Text = string.Format("{0:0.000}", point(m1) * u1);
            Ptxt2.Text = string.Format("{0:0.000}", point(m2) * u2);
            Ptxt3.Text = string.Format("{0:0.000}", point(m3) * u3);

            cptxt.Text = Convert.ToString(tu);
            gpatxt.Text= string. Format("{0:0.00}", ggpa);


        }
        double point(int mark)
        {
            double p = 0;
            if (mark < 25)
            {
                p = 0;
            }
            else if (mark >= 25 && mark < 30)
            {
                p = 1;
            }
            else if (mark >= 30 && mark < 35)
            {
                p = 1.3;
            }
            else if (mark >= 35 && mark < 40)
            {
                p = 1.7;
            }
            else if (mark >= 40 && mark < 45)
            {
                p = 2;
            }
            else if (mark >= 45 && mark < 50)
            {
                p = 2.3;
            }
            else if (mark >= 50 && mark < 55)
            {
                p = 2.7;
            }
            else if (mark >= 55 && mark < 60)
            {
                p = 3;
            }
            else if (mark >= 60 && mark < 65)
            {
                p = 3.3;
            }
            else if (mark >= 65 && mark < 70)
            {
                p = 3.7;
            }
            else
            {
                p = 4;
            }
            return p;

        }

        string Grade(int mark)
        {
            string p = " ";
            if (mark < 25)
            {
                p = "E";
            }
            else if (mark >= 25 && mark < 30)
            {
                p = "D";
            }
            else if (mark >= 30 && mark < 35)
            {
                p = "D+";
            }
            else if (mark >= 35 && mark < 40)
            {
                p = "C-";
            }
            else if (mark >= 40 && mark < 45)
            {
                p = "C";
            }
            else if (mark >= 45 && mark < 50)
            {
                p = "C+";
            }
            else if (mark >= 50 && mark < 55)
            {
                p = "B-";
            }
            else if (mark >= 55 && mark < 60)
            {
                p = "B";
            }
            else if (mark >= 60 && mark < 65)
            {
                p = "B+";
            }
            else if (mark >= 65 && mark < 70)
            {
                p = "A-";
            }
            else if (mark >= 70 && mark < 85)
            {
                p = "A";
            }
            else
            {
                p = "A+";
            }
            return p;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            FNameTextBox.Text = "";
            LNameTextBox.Text = "";
            RNumberTextBox.Text = "";

            stxt4.Text = "";
            stxt5.Text = "";
            stxt6.Text = "";

            Gtxt1.Text = "";
            Gtxt2.Text = "";
            Gtxt3.Text = "";

            Ptxt1.Text = "";
            Ptxt2.Text = "";
            Ptxt3.Text = "";           

            gpatxt.Text = "";
        }
    }
}

