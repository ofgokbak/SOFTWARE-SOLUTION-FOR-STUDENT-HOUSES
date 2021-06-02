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
    public partial class AddComplainGUI : Form
    {
        Student student = new Student();
        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();
        List<TimeTable> timetable;
        List<Student> students;
        List<Messages> studentmessages;
        public AddComplainGUI(Student currentStudent, List<TimeTable> floortimetable, List<Student> studentlist, List<Messages> messages)
        {
            InitializeComponent();
            student = currentStudent;
            timetable = floortimetable;
            students = studentlist;
            system.Students = students;
            studentmessages = messages;

        }

        private void AddComplainGUI_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CheckNotification();
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            btnComplains.BackColor = Color.FromArgb(120, 0, 153);
            lbUsername.Text = student.Firstname;
            lbPenatly.Text = $"Penalty Points = {student.Penalty}";
            tbComplainText.ForeColor = Color.Gray;
            tbComplainTopic.ForeColor = Color.Gray;
        }

        private void btnComplainAdd_Click(object sender, EventArgs e)
        {
            // Check whether textboxes are empty.If not 
            if (!String.IsNullOrWhiteSpace(tbComplainText.Text) && !String.IsNullOrWhiteSpace(tbComplainTopic.Text))
            {
                int studentid = student.Studentid;
                string complaintopic = tbComplainTopic.Text;
                string complaintext = tbComplainText.Text;
                string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

                database.AddComplain(studentid, complaintopic, complaintext, date);
                MessageBox.Show("Complain Submitted!");

            }
            else
            {
                //If a textbox is not filled.
                MessageBox.Show("Fill in Topic and Message");
            }
        }

       

        private void lbback_Click(object sender, EventArgs e)
        {
            ComplainsGUI newTab = new ComplainsGUI(student, timetable, students,studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void tbComplainTopic_Click(object sender, EventArgs e)
        {
            tbComplainText.ForeColor = Color.Black;
            tbComplainTopic.ForeColor = Color.Black;
            if (tbComplainTopic.Text == "Please enter your topic")
            {
                tbComplainTopic.Clear();
            }
        }

        private void tbComplainText_Click(object sender, EventArgs e)
        {
            tbComplainText.ForeColor = Color.Black;
            tbComplainTopic.ForeColor = Color.Black;
            if (tbComplainText.Text == "Please enter your problem")
            {
                tbComplainText.Clear();
            }
        }

      

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
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

        public void CheckNotification()
        {
            if (studentmessages.Exists(x => x.Ismessageread == false))
            {
                pictureex.Visible = true;
            }
            else {
                pictureex.Visible = false;
            }
        }
    }
}
