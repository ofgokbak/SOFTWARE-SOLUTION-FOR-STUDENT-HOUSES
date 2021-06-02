using StudentHousingBV.AdminGUI;
using StudentHousingBV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.GUI
{
    public partial class LoginGUI : Form
    {
        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();
        
        List<Student> students;
        public LoginGUI()
        {
            InitializeComponent();
            students = database.GetStudents();
            system.Students = students;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void tbusername_Click(object sender, EventArgs e)
        {
            tbusername.Clear();
            userline.BackColor = Color.FromArgb(215, 16, 82);
            passline.BackColor = Color.FromArgb(74, 51, 138);
        }

        private void tbpassword_Click(object sender, EventArgs e)
        {
            tbpassword.Clear();
            tbpassword.PasswordChar = '*';
            passline.BackColor = Color.FromArgb(215, 16, 82);
            userline.BackColor = Color.FromArgb(74, 51, 138);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             if (system.GetLogin(tbusername.Text, tbpassword.Text))
            {

                if (system.isAdmin(tbusername.Text))
                {
                    AdminMGUI pg = new AdminMGUI(students);
                    pg.Show();
                    this.Hide();
                }
                else
                {
                    
                    var student = new Student();
                    student = system.GetStudent(tbusername.Text);
                    List<TimeTable> timetable = database.GetFloorTimeTable(student.Floorid);
                    List<Messages> messages = database.GetMessages(student.Studentid);
                    TimeTableGUI pg = new TimeTableGUI(student,timetable,students,messages);
                    pg.Show();
                    this.Hide();


                }
            }
            else
            {
                MessageBox.Show("Your details are wrong!");
            }
        }


        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
