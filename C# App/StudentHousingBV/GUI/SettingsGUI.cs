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
    public partial class SettingsGUI : Form
    {
        Student student = new Student();
        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();
        List<TimeTable> timetable;
        List<Student> students;
        List<Messages> studentmessages;
        public SettingsGUI(Student currentStudent, List<TimeTable> floortimetable, List<Student> studentlist, List<Messages> messages)
        {
            InitializeComponent();
            student = currentStudent;
            timetable = floortimetable;
            students = studentlist;
            system.Students = students;
            studentmessages = messages;
        }

        public void CheckNotification()
        {
            if (studentmessages.Exists(x => x.Ismessageread == false))
            {
                pictureex.Visible = true;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            tboldpas.PasswordChar = '*';
            tbnewpas.PasswordChar = '*';
            tbnewpas2.PasswordChar = '*';
            tbxEmailPass.PasswordChar = '*';
            tbxNumberPass.PasswordChar = '*';
            updatestudentinfo();
            btnSettings.BackColor = Color.FromArgb(120, 0, 153);
            lbUsername.Text = student.Firstname;
            lbpenaltypoints.Text = $"Penalty Points = {student.Penalty}";
            pictureex.Visible = false;
            CheckNotification();
        }

        private void Settings_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
 

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
        }

        private void btnMyTimetable_Click(object sender, EventArgs e)
        {
            TimeTableGUI newTab = new TimeTableGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnComplains_Click(object sender, EventArgs e)
        {
            ComplainsGUI newTab = new ComplainsGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnAnouncements_Click(object sender, EventArgs e)
        {
            AnnouncementsAndRulesGUI newTab = new AnnouncementsAndRulesGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            InBox newTab = new InBox(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsGUI newTab = new SettingsGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void picturemessage_Click(object sender, EventArgs e)
        {
            if (studentmessages.Exists(x => x.Ismessageread == false))
            {
                MessageBox.Show("You have new message! Please check your inbox");
            }
        }

        private void pictureex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have new message! Please check your inbox");
        }

        private void lbsurname_Click(object sender, EventArgs e)
        {

        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tboldpas.Text) || string.IsNullOrWhiteSpace(tbnewpas.Text)|| string.IsNullOrWhiteSpace(tbnewpas2.Text))
            {
                MessageBox.Show("Please fill in the gaps!");
            }
            else
            {
                if(tboldpas.Text != student.Password)
                {
                    MessageBox.Show("Your old password is wrong!");
                }else if(tbnewpas.Text != tbnewpas2.Text)
                {
                    MessageBox.Show("Passwords are not matched!");
                }else
                {
                    database.ChangePassword(student.Studentid, tbnewpas.Text);
                    MessageBox.Show("Password changed!");
                }
                
            }
        }

        private void btnchangeemail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbnewemail.Text))
                MessageBox.Show("Please fill in your new email!");
            else if (string.IsNullOrEmpty(tbxEmailPass.Text))
            {
                MessageBox.Show("Please fill in your password!");
            }

            if (tbxEmailPass.Text != student.Password)
                MessageBox.Show("Wrong password!");
            else
            {
                database.ChangeEmail(student.Studentid, tbnewemail.Text);
                MessageBox.Show("Email changed!");
            }
        }

        private void btnchangenumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbnewnumber.Text))
                MessageBox.Show("Please fill in your new number!");
            else if (string.IsNullOrEmpty(tbxNumberPass.Text))
            {
                MessageBox.Show("Please fill in your password!");
            }

            if (tbxNumberPass.Text != student.Password)
                MessageBox.Show("Wrong password!");
            else
            {
                database.ChangeNumber(student.Studentid, tbnewnumber.Text);
                MessageBox.Show("Phone number changed!");
            }
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            tboldpas.PasswordChar = '\0';
            tbnewpas.PasswordChar = '\0';
            tbnewpas2.PasswordChar = '\0';

        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            tboldpas.PasswordChar = '*';
            tbnewpas.PasswordChar = '*';
            tbnewpas2.PasswordChar = '*';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }

        public void updatestudentinfo()
        {
            system.GetStudents();
            student = system.GetStudentbyID(student.Studentid);
            lbname.Text = student.Firstname;
            lbsurname.Text = student.Lastname;
            lbroomid.Text = student.Roomid.ToString();
            lbemail.Text = student.Email;
            lbnumber.Text = student.Phonenumber;
            lbpenalty.Text = $"Penalty Point: {student.Penalty}";
        }
    }
}
